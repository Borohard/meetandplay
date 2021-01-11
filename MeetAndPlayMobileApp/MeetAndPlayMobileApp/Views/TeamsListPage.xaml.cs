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
        public TeamsListPage()
        {
            InitializeComponent();
            BindingContext = new RequestsListViewModel() { Navigation = this.Navigation };
        }
    }
}