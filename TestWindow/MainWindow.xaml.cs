using DentWhiteTest.Contacts;
using DentWhiteTest.Module.Denture;
using DentWhiteTest.Module.Doctor;
using System.ComponentModel;
using System.Windows;
using TestWindow.ViewModel;

namespace WhiteWindow
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        bool isRunning = false;


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void btnALL_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            //德雅管理后台模块
            DentureLoginModule.LoginAllTest();
            HospitalModule.HospitalAllTest();
            DoctorModule.DoctorAllTest();
            DentureModule.DentureAllTest();
            RoleModule.RoleAllTest();
            DoctorModule.DoctorAllTest();

            //医生端模块
            DoctorLoginModule.LoginAllTest();
            isRunning = false;

            this.Activate();

        }

        #region 德雅管理后台模块

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDentureLogin_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            DentureLoginModule.LoginAllTest();
            isRunning = false;

            this.Activate();
        }

        /// <summary>
        /// 医院管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHospital_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            HospitalModule.HospitalAllTest();
            isRunning = false;

            this.Activate();
        }

        /// <summary>
        /// 医生管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoctor_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            DoctorModule.DoctorAllTest();
            isRunning = false;

            this.Activate();
        }

        /// <summary>
        /// 排牙师管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDenture_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            DentureModule.DentureAllTest();
            isRunning = false;

            this.Activate();
        }

        /// <summary>
        /// 角色管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRole_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            RoleModule.RoleAllTest();
            isRunning = false;

            this.Activate();
        }

        /// <summary>
        /// 用户管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            DoctorModule.DoctorAllTest();
            isRunning = false;

            this.Activate();
        }

        #endregion

        #region 医生端模块

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoctorLogin_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            DoctorLoginModule.LoginAllTest();
            isRunning = false;

            this.Activate();
        }

        /// <summary>
        /// 上传报告
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUploadReport_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            OrderListModule.DoctorAllTest();
            isRunning = false;

            this.Activate();
        }

        /// <summary>
        /// (技工厂)医院管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFactoryHospital_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            FactoryHospitalModule.HospitalAllTest();
            isRunning = false;

            this.Activate();
        }

        #endregion

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        #endregion

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
