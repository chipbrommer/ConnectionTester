using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionTester.Utilities;
using System.Windows.Input;
using ConnectionTester.View;
using System.Transactions;
using System.Windows.Controls;

namespace ConnectionTester.ViewModel
{
    class MainVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }
        
        public ICommand DashboardCommand { get; set; }
        public ICommand SettingsCommand { get; set; }

        public static object DashboardInstance { get; } = new DashboardVM();
        public static SettingsVM SettingsInstance { get; } = new SettingsVM();
        private void Dashboard(object obj) => CurrentView = DashboardInstance;
        private void Settings(object obj) => CurrentView = SettingsInstance;

        public MainVM()
        {
            DashboardCommand = new RelayCommand(Dashboard);
            SettingsCommand = new RelayCommand(Settings);

            // Startup Page
            CurrentView = DashboardInstance;
        }
    }
}
