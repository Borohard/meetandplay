using MeetAndPlayMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeetAndPlayMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        
        public ObservableCollection<RequestViewModel> Requestss { get; set; }
        public Page1()
        {
            InitializeComponent();           
            BindingContext = new RequestsListViewModel() { Navigation = this.Navigation };


            



            var viewModel = (RequestsListViewModel)BindingContext;
            if (viewModel.RefreshCommand.CanExecute(null)) viewModel.RefreshCommand.Execute(requestsCollection);           
            Requestss = (ObservableCollection<RequestViewModel>)requestsCollection.ItemsSource;
            //requestsCollection.ItemsSource = new ObservableCollection<RequestViewModel>(Requestss.Where((request) => request.CurrentPlayersCount.ToString.Contains(.ToLower())));
        }

        private void requestsCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(requestsCollection.SelectedItem != null)
            {
                requestsCollection.SelectedItem = null;
            }
        }

        private void requestsCollection_BindingContextChanged(object sender, EventArgs e)
        {
            Requestss = (ObservableCollection<RequestViewModel>)requestsCollection.ItemsSource;
            requestsCollection.ItemsSource = new ObservableCollection<RequestViewModel>(Requestss.Where((request) => request.CurrentPlayersCount == 1));
            
        }

        
    }
}