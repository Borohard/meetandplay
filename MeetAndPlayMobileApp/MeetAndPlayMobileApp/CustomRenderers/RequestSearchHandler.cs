using MeetAndPlayMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MeetAndPlayMobileApp.ViewModels;
using System.Collections.ObjectModel;
using MeetAndPlayMobileApp.Views;

namespace MeetAndPlayMobileApp.CustomRenderers
{
    public class RequestSearchHandler : SearchHandler
    {
        
        public ObservableCollection<RequestViewModel> Requestss { get; set; }

        public TeamsListPage teams { get; set; }
        public Type SelectedItemNavigationTarget { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {

                ItemsSource = new ObservableCollection<RequestViewModel>(Requestss.Where((request) => request.Title.ToLower().Contains(newValue.ToLower())));

                    // Requestss.Where(request => request.Title.ToLower().Contains(newValue.ToLower())).ToList<RequestViewModel>();
            }
        }

   
    }
}
