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
            //德雅管理后台
            DentureLoginModule.LoginAllTest();
            HospitalModule.HospitalAllTest();
            DoctorModule.DoctorAllTest();
            DentureModule.DentureAllTest();
            RoleModule.RoleAllTest();
            DoctorModule.DoctorAllTest();

            //Dentlab 客户端
            DoctorLoginModule.LoginAllTest();
            FactoryHospitalModule.HospitalAllTest();
            TechnicianListModule.TechnicianAllTest();
            UploadReportModule.DoctorAllTest();

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

        private void btnFactory_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            FactoryModule.FactoryAllTest();
            isRunning = false;

            this.Activate();
        }

        #endregion

        #region Dentlab 客户端模块

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

        #region 技工厂端

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

        /// <summary>
        /// 技师管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTechnician_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            TechnicianListModule.TechnicianAllTest();
            isRunning = false;

            this.Activate();
        }

        /// <summary>
        /// (技工厂端)医生管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFactory_DoctorManage_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            DoctorManageModule.Factory_DoctorManageAllTest();
            isRunning = false;

            this.Activate();
        }

        /// <summary>
        /// 技工厂管理员端 新增订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFactoryAddOrder_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            AddOrderModule.Factory_AddOrderTest();
            isRunning = false;

            this.Activate();
        }

        #endregion

        #region 医生端

        /// <summary>
        /// 医生端 新增订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoctorAddOrder_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            AddOrderModule.Doctor_AddOrderTest();
            isRunning = false;

            this.Activate();
        }

        #endregion

        #region 技师端

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
            UploadReportModule.DoctorAllTest();
            isRunning = false;

            this.Activate();
        }

        #endregion

        #region 医生管理员端

        /// <summary>
        /// 医生管理员端 新增订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoctorAdminAddOrder_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            AddOrderModule.Doctor_AddOrderTest();
            isRunning = false;

            this.Activate();
        }

        /// <summary>
        /// (医生管理员端)医生管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoctorAdmin_DoctorManage_Click(object sender, RoutedEventArgs e)
        {
            if (isRunning)
            {
                Global.LstInfo = new System.Collections.ObjectModel.ObservableCollection<string>();
                Global.LstInfo.Add("已经有测试用例在执行！");
                return;
            }

            isRunning = true;
            DoctorManageModule.DoctorAdmin_DoctorManageAllTest();
            isRunning = false;

            this.Activate();
        }

        #endregion

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
    }
}
