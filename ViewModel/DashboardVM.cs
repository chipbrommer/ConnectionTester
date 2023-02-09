using ConnectionTester.Model;
using ConnectionTester.Utilities;
using ConnectionTester.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace ConnectionTester.ViewModel
{
    class DashboardVM : ViewModelBase
    {
        #region properties
        public ObservableCollection<TestItem> Comp1DOList { get; set; }
        public RelayCommand AddItemCommand { get; set;}
        public ObservableCollection<TestItem> Comp1DIList { get; set; }
        public ObservableCollection<TestItem> Comp1DCList { get; set; }
        public ObservableCollection<TestItem> Comp2DOList { get; set; }
        public ObservableCollection<TestItem> Comp2DIList { get; set; }
        public ObservableCollection<TestItem> Comp2DCList { get; set; }
        public ObservableCollection<TestItem> Comp3DOList { get; set; }
        public ObservableCollection<TestItem> Comp3DIList { get; set; }
        public ObservableCollection<TestItem> Comp3DCList { get; set; }
        public ObservableCollection<TestItem> Comp4DOList { get; set; }
        public ObservableCollection<TestItem> Comp4DIList { get; set; }
        public ObservableCollection<TestItem> Comp4DCList { get; set; }

        private readonly PageModel _pageModel;
        private string _StartButtonText,
                        _WaveRelayEthernetText,
                        _WaveRelaySignal1Text,
                        _MetSerialText,
                        _MetSignal1Text, 
                        _MetSignal2Text, 
                        _MetSignal3Text,
                        _EthNic1Text,
                        _EthNic2Text,
                        _EthNic3Text,
                        _Comp1EthText,
                        _Comp1SerialText,
                        _Comp1DoText,
                        _Comp1DiText,
                        _Comp2EthText,
                        _Comp2SerialText,
                        _Comp2DoText,
                        _Comp2DiText,
                        _Comp3EthText,
                        _Comp3SerialText,
                        _Comp3DoText,
                        _Comp3DiText,
                        _Comp4EthText,
                        _Comp4SerialText,
                        _Comp4DoText,
                        _Comp4DiText;
        private bool isTestRunning;
        #endregion

        #region functions
        private void SetTestItemsToQueued()
        {
            WaveRelayEthernetText = TestItemStatusEnumToString(TestItemStatus.Queued);
            WaveRelaySignal1Text = TestItemStatusEnumToString(TestItemStatus.Queued);
            MetSerialText = TestItemStatusEnumToString(TestItemStatus.Queued);
            MetSignal1Text = TestItemStatusEnumToString(TestItemStatus.Queued);
            MetSignal2Text = TestItemStatusEnumToString(TestItemStatus.Queued);
            MetSignal3Text = TestItemStatusEnumToString(TestItemStatus.Queued);
            EthNic1Text = TestItemStatusEnumToString(TestItemStatus.Queued);
            EthNic2Text = TestItemStatusEnumToString(TestItemStatus.Queued);
            EthNic3Text = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp1EthText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp1SerialText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp1DoText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp1DiText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp2EthText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp2SerialText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp2DoText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp2DiText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp3EthText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp3SerialText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp3DoText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp3DiText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp4EthText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp4SerialText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp4DoText = TestItemStatusEnumToString(TestItemStatus.Queued);
            Comp4DiText = TestItemStatusEnumToString(TestItemStatus.Queued);
        }

        private void ResetTestItems()
        {
            WaveRelayEthernetText = TestItemStatusEnumToString(TestItemStatus.Reset);
            WaveRelaySignal1Text = TestItemStatusEnumToString(TestItemStatus.Reset);
            MetSerialText = TestItemStatusEnumToString(TestItemStatus.Reset);
            MetSignal1Text = TestItemStatusEnumToString(TestItemStatus.Reset);
            MetSignal2Text = TestItemStatusEnumToString(TestItemStatus.Reset);
            MetSignal3Text = TestItemStatusEnumToString(TestItemStatus.Reset);
            EthNic1Text = TestItemStatusEnumToString(TestItemStatus.Reset);
            EthNic2Text = TestItemStatusEnumToString(TestItemStatus.Reset);
            EthNic3Text = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp1EthText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp1SerialText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp1DoText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp1DiText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp2EthText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp2SerialText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp2DoText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp2DiText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp3EthText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp3SerialText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp3DoText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp3DiText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp4EthText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp4SerialText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp4DoText = TestItemStatusEnumToString(TestItemStatus.Reset);
            Comp4DiText = TestItemStatusEnumToString(TestItemStatus.Reset);
        }

        private int StartTest()
        {
            SetTestItemsToQueued();

            MessageBox.Show("Please plug in Comp 1");

            // Start program. 
            TestRunning = true;
            WaveRelayEthernetText = TestItemStatusEnumToString(TestItemStatus.InProgress);

            for (int i = 0; i < 10; i++)
            {

            }

            return 0;
        }

        private bool TestRunning
        {
            get { return isTestRunning; }
            set
            {
                isTestRunning = value;
                if (isTestRunning) { StartButtonText = "Stop Test"; }
                else
                {
                    StartButtonText = "Start Test";
                    ResetTestItems();
                }
                NotifyPropertyChanged("TestRunning");
            }
        }

        public ICommand StartButtonCommand { get; set; }

        private void StartButtonClick(object sender)
        {
            if (TestRunning)
            {
                TestRunning = false;
            }
            else
            {
                int rtn = StartTest();

                if (rtn == -1)
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private string TestItemStatusEnumToString(TestItemStatus temp)
        {
            if (temp == TestItemStatus.Reset) { return string.Empty; }
            else if (temp == TestItemStatus.Queued) { return "Queued"; }
            else if (temp == TestItemStatus.InProgress) { return "In Progress"; }
            else if (temp == TestItemStatus.Pass) { return "Pass"; }
            else if (temp == TestItemStatus.Fail) { return "Fail"; }
            else { return string.Empty; }
        }

        #endregion

        public DashboardVM()
        {
            _pageModel              = new PageModel();
            _StartButtonText        = "Start Test";
            _WaveRelayEthernetText  = string.Empty;
            _WaveRelaySignal1Text   = string.Empty;
            _MetSerialText          = string.Empty;
            _MetSignal1Text         = string.Empty;
            _MetSignal2Text         = string.Empty;
            _MetSignal3Text         = string.Empty;
            _EthNic1Text            = string.Empty;
            _EthNic2Text            = string.Empty;
            _EthNic3Text            = string.Empty;
            _Comp1EthText           = string.Empty;
            _Comp1SerialText        = string.Empty;
            _Comp1DoText            = string.Empty;
            _Comp1DiText            = string.Empty;
            _Comp2EthText           = string.Empty;
            _Comp2SerialText        = string.Empty;
            _Comp2DoText            = string.Empty;
            _Comp2DiText            = string.Empty;
            _Comp3EthText           = string.Empty;
            _Comp3SerialText        = string.Empty;
            _Comp3DoText            = string.Empty;
            _Comp3DiText            = string.Empty;
            _Comp4EthText           = string.Empty;
            _Comp4SerialText        = string.Empty;
            _Comp4DoText            = string.Empty;
            _Comp4DiText            = string.Empty;
            StartButtonCommand      = new RelayCommand(o => StartButtonClick("StartButton"));

            var testList = new List<TestItem>();
            testList.Add(new TestItem { Name="eth1", Output="8 bytes", Status="PASS" });
            Comp1DOList = new ObservableCollection<TestItem>(testList);
        }

        #region Text Handlers
        public string StartButtonText
        {
            get { return _StartButtonText; }
            set { _StartButtonText = value; NotifyPropertyChanged("StartButtonText"); }
        }
        public string WaveRelayEthernetText
        {
            get { return _WaveRelayEthernetText; }
            set { _WaveRelayEthernetText = value; NotifyPropertyChanged("WaveRelayEthernetText"); }
        }
        public string WaveRelaySignal1Text
        {
            get { return _WaveRelaySignal1Text; }
            set { _WaveRelaySignal1Text = value; NotifyPropertyChanged("WaveRelaySignal1Text"); }
        }
        public string MetSerialText
        {
            get { return _MetSerialText; }
            set { _MetSerialText = value; NotifyPropertyChanged("MetSerialText"); }
        }
        public string MetSignal1Text
        {
            get { return _MetSignal1Text; }
            set { _MetSignal1Text = value; NotifyPropertyChanged("MetSignal1Text"); }
        }
        public string MetSignal2Text
        {
            get { return _MetSignal2Text; }
            set { _MetSignal2Text = value; NotifyPropertyChanged("MetSignal2Text"); }
        }
        public string MetSignal3Text
        {
            get { return _MetSignal3Text; }
            set { _MetSignal3Text = value; NotifyPropertyChanged("MetSignal3Text"); }
        }
        public string EthNic1Text
        {
            get { return _EthNic1Text; }
            set { _EthNic1Text = value; NotifyPropertyChanged("EthNic1Text"); }
        }
        public string EthNic2Text
        {
            get { return _EthNic2Text; }
            set { _EthNic2Text = value; NotifyPropertyChanged("EthNic2Text"); }
        }
        public string EthNic3Text
        {
            get { return _EthNic3Text; }
            set { _EthNic3Text = value; NotifyPropertyChanged("EthNic3Text"); }
        }
        public string Comp1EthText
        {
            get { return _Comp1EthText; }
            set { _Comp1EthText = value; NotifyPropertyChanged("Comp1EthText"); }
        }
        public string Comp1SerialText
        {
            get { return _Comp1SerialText; }
            set { _Comp1SerialText = value; NotifyPropertyChanged("Comp1SerialText"); }
        }
        public string Comp1DoText
        {
            get { return _Comp1DoText; }
            set { _Comp1DoText = value; NotifyPropertyChanged("Comp1DoText"); }
        }
        public string Comp1DiText
        {
            get { return _Comp1DiText; }
            set { _Comp1DiText = value; NotifyPropertyChanged("Comp1DiText"); }
        }
        public string Comp2EthText
        {
            get { return _Comp2EthText; }
            set { _Comp2EthText = value; NotifyPropertyChanged("Comp2EthText"); }
        }
        public string Comp2SerialText
        {
            get { return _Comp2SerialText; }
            set { _Comp2SerialText = value; NotifyPropertyChanged("Comp2SerialText"); }
        }
        public string Comp2DoText
        {
            get { return _Comp2DoText; }
            set { _Comp2DoText = value; NotifyPropertyChanged("Comp2DoText"); }
        }
        public string Comp2DiText
        {
            get { return _Comp2DiText; }
            set { _Comp2DiText = value; NotifyPropertyChanged("Comp2DiText"); }
        }
        public string Comp3EthText
        {
            get { return _Comp3EthText; }
            set { _Comp3EthText = value; NotifyPropertyChanged("Comp3EthText"); }
        }
        public string Comp3SerialText
        {
            get { return _Comp3SerialText; }
            set { _Comp3SerialText = value; NotifyPropertyChanged("Comp3SerialText"); }
        }
        public string Comp3DoText
        {
            get { return _Comp3DoText; }
            set { _Comp3DoText = value; NotifyPropertyChanged("Comp3DoText"); }
        }
        public string Comp3DiText
        {
            get { return _Comp3DiText; }
            set { _Comp3DiText = value; NotifyPropertyChanged("Comp3DiText"); }
        }
        public string Comp4EthText
        {
            get { return _Comp4EthText; }
            set { _Comp4EthText = value; NotifyPropertyChanged("Comp4EthText"); }
        }
        public string Comp4SerialText
        {
            get { return _Comp4SerialText; }
            set { _Comp4SerialText = value; NotifyPropertyChanged("Comp4SerialText"); }
        }
        public string Comp4DoText
        {
            get { return _Comp4DoText; }
            set { _Comp4DoText = value; NotifyPropertyChanged("Comp4DoText"); }
        }
        public string Comp4DiText
        {
            get { return _Comp4DiText; }
            set { _Comp4DiText = value; NotifyPropertyChanged("Comp4DiText"); }
        }
        #endregion
        
    }
}
