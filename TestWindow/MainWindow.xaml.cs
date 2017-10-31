using DentWhiteTest.Contacts;
using DentWhiteTest.Module;
using System.ComponentModel;
using System.Windows;
using TestWindow.ViewModel;
using WhiteFrameDemo.Module;

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
            LoginModule.LoginAllTest();
            HospitalModule.HospitalAllTest();
            DoctorModule.DoctorAllTest();
            DockerModule.DockerAllTest();
            RoleModule.RoleAllTest();
            DoctorModule.DoctorAllTest();
            isRunning = false;

            this.Activate();
           
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            LoginModule.LoginAllTest();
            isRunning = false;

            this.Activate();
        }

        #region 德雅管理后台模块

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
        private void btnDocker_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            DockerModule.DockerAllTest();
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

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(name));
            }
        }

        #endregion

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
