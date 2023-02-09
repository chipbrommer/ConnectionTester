using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using ConnectionTester.Model;
using ConnectionTester.Utilities;

namespace ConnectionTester.ViewModel
{
    public partial class SettingsVM : ViewModelBase
    {
        private readonly PageModel _pageModel;
        [ObservableProperty]
        private string _appVersion = String.Empty;

        public SettingsVM()
        {
            _pageModel = new PageModel();
            AppVersion = $"ConnectionTester - v{GetAssemblyVersion()}";
        }

        private string GetAssemblyVersion()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? String.Empty;
        }
    }
}
