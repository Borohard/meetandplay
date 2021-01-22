using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetAndPlayMobileApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MeetAndPlayMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            
            InitializeComponent();
            
            BindingContext = bruh.BindingContext;
            FilterByLName.Requestss = new RequestsListViewModel().Requests;
            
        }

        
    }
}
