using MeetAndPlayMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeetAndPlayMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeamsListPage : ContentPage
    {
        private double _scale = 1;
        
        public TeamsListPage()
        {
            InitializeComponent();
            BindingContext = new RequestsListViewModel() { Navigation = this.Navigation };
            
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await addIcon.ScaleTo(_scale * 1.3, 200);
            await addIcon.ScaleTo(_scale, 200);
            
        }

        private void requestsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            requestsList.SelectionMode = ListViewSelectionMode.None;
            requestsList.SelectionMode = ListViewSelectionMode.Single;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            

        }
    }
    
}