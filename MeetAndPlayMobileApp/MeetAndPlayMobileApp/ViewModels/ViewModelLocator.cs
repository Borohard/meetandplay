using System;
using System.Collections.Generic;
using System.Text;

namespace MeetAndPlayMobileApp.ViewModels
{
    public static class ViewModelLocator
    {
        private static RequestsListViewModel _myViewModel = new RequestsListViewModel() ;
        public static RequestsListViewModel MainViewModel
        {
            
            get
            {
                return _myViewModel;
            }
        }
    }
}
