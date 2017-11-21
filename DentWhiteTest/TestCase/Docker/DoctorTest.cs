using DentWhiteTest.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.ListBoxItems;

namespace DentWhiteTest.TestCase
{
    public class DoctorTest
    {
        #region 医生列表

        /// <summary>
        /// 点击医生管理菜单，加载所有医生
        /// </summary>
        public static bool Load_DoctorList(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //在菜单页选择医生管理
                Button tlDoctorManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlDoctorManagement"));
                tlDoctorManagement.Click();
                var endTime = DateTime.Now;

                msg = "测试【点击医生管理菜单，加载所有医生】--通过，用时：" + (endTime - startTime).TotalSeconds;
                return true;
            }
            catch (Exception e)
            {
                msg = "测试【点击医生管理菜单，加载所有医生】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入账号名，点击查询按钮，加载该医生
        /// </summary>
        /// 账号名：txtAccountName
        public static bool Search_DoctoruserName(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //输入账号名
                TextBox txtAccountName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtAccountName"));
                txtAccountName.BulkText = "w";

                //点击查询
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                //输入账号名
                TextBox txtAccountName1 = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtAccountName"));
                txtAccountName1.BulkText = "bwl_doctor";

                //点击查询
                Button btnSearchOrderList1= appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList1.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();
                    msg = "测试【输入账号名，点击查询按钮，加载该医生】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入账号名，点击查询按钮，加载该医生】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【输入账号名，点击查询按钮，加载该医生】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入医生名称，点击查询按钮，加载该医生
        /// </summary>
        public static bool Search_DoctorName(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //输入账号名称为空
                TextBox txtAccountName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtAccountName"));
                txtAccountName.BulkText = "";

                //输入医生名称
                TextBox txtDoctorName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = "lbw";

                //点击查询
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();
                    msg = "测试【输入医生名称，点击查询按钮，加载该医生】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入医生名称，点击查询按钮，加载该医生】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【输入医生名称，点击查询按钮，加载该医生】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 选择是否在线，点击查询按钮，加载是否在线医生
        /// </summary>
        public static bool Search_DoctorUnOnline(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //输入账号名称为空
                TextBox txtAccountName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtAccountName"));
                txtAccountName.BulkText = "";

                //输入医生名称为空
                TextBox txtDoctorName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = "";

                //选择下线的医生
                ComboBox cbIsOnline = appWin.Get<ComboBox>(SearchCriteria.ByAutomationId("cbIsOnline"));
                cbIsOnline.Select(1);

                //点击查询
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                //选择在线的医生
                ComboBox DoctorOnline = appWin.Get<ComboBox>(SearchCriteria.ByAutomationId("cbIsOnline"));
                cbIsOnline.Select(2);

                //点击查询
                Button btnSearchOrderList1= appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList1.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();
                    msg = "测试【选择是否在线，点击查询按钮，加载该医生】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【选择是否在线，点击查询按钮，加载该医生】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【选择是否在线，点击查询按钮，加载该医生】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 医生名称为空，点击查询按钮，加载所有医生
        /// </summary>
        public static bool Search_DoctorNameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //输入账号名称为空
                TextBox txtAccountName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtAccountName"));
                txtAccountName.BulkText = "";

                //输入医生名称为空
                TextBox txtDoctorName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = "";

                //选择不区分的医生
                ComboBox cbIsOnline = appWin.Get<ComboBox>(SearchCriteria.ByAutomationId("cbIsOnline"));
                cbIsOnline.Select(0);

                //点击查询
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();
                    msg = "测试【输入医生名称，点击查询按钮，加载该医生】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入医生名称，点击查询按钮，加载该医生】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【医生名称为空，点击查询按钮，加载所有医生】--失败，原因：" + e.ToString();
                return false;
            }
        }


        #endregion

        #region 新增医生

        /// <summary>
        /// 新增医生，账号名为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>

        public static bool AddDoctor_DoctorNameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddDoctor"));
                btnAddDoctor.Click();

                //账号名称为空
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.Text = "";

                //点击确定按钮
                Button btnComfirmAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddDoctor"));
                btnComfirmAddDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入账号名！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医生，医生名称为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医生，医生名称为空】--未通过，缺少账号名称空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医生，医生名称为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医生，账号名称最少5个字|多于30个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
       
        public static bool AddDoctor_DoctorNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //账号名称少于1个字符
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.Text = "z";

                //点击确定按钮
                Button btnComfirmAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddDoctor"));
                btnComfirmAddDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名最少5个字，最多30个字！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //账号名称多于30个字符
                    txtDoctorName.BulkText = Generate.GenerateChineseWords(31);

                    //点击确定按钮
                    btnComfirmAddDoctor.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名最少5个字，最多30个字！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增医生，账号名称最少5个字|多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增医生，账号名称最少5个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【新增医生，账号名称最少5个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医生，账号名称最少5个字|多于30个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医生，密码为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
       
        public static bool AddDoctor_PwdBull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                //Button btnAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddDoctor"));
                //btnAddDoctor.Click();

                //正确账号名称
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = Generate.GenerateChineseWords(5);

                //密码为空
                TextBox pwdDoctorPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdDoctorPwd"));
                pwdDoctorPwd.Text = "";

                //点击确定按钮
                Button btnComfirmAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddDoctor"));
                btnComfirmAddDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入密码！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医生，密码为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医生，密码为空】--未通过，缺少密码空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医生，密码为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医生，密码少于8位|多于30位
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
       
        public static bool AddDoctor_PwdLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                //Button btnAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddDoctor"));
                //btnAddDoctor.Click();

                //账号名称不为空
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = Generate.GenerateChineseWords(5);

                //密码少于8位
                TextBox pwdDoctorPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdDoctorPwd"));
                pwdDoctorPwd.Text = "123";

                //点击确定按钮
                Button btnComfirmAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddDoctor"));
                btnComfirmAddDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8位，最多30位！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //密码多于30位
                    pwdDoctorPwd.Text = "1233444444444444444444444444444444444444";

                    //点击确定按钮
                    btnComfirmAddDoctor.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8位，最多30位！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增医生，密码少于8位|多于30位】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增医生，密码少于8位|多于30位】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【新增医生，密码少于8位|多于30位】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医生，密码少于8位|多于30位】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医生，邮箱地址格式不正确
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        
        public static bool AddDoctor_EmailError(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                //Button btnAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddDoctor"));
                //btnAddDoctor.Click();

                //账号名不为空
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdDoctorPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdDoctorPwd"));
                pwdDoctorPwd.Text = "12345678";

                //邮箱地址格式不正确
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "ff";

                //点击确定按钮
                Button btnComfirmAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddDoctor"));
                btnComfirmAddDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("邮箱地址格式不正确！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医生，邮箱地址格式不正确】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医生，邮箱地址格式不正确】--未通过，缺少邮箱地址验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医生，邮箱地址格式不正确】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医生，真实姓名为空|真实姓名多于30个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        
        public static bool AddDoctor_RealNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                //Button btnAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddDoctor"));
                //btnAddDoctor.Click();

                //正确账号名称
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdDoctorPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdDoctorPwd"));
                pwdDoctorPwd.Text = "12345678";

                //真实姓名为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.Text = "";

                //点击确定按钮
                Button btnComfirmAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddDoctor"));
                btnComfirmAddDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入真实姓名！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //真实姓名多于30个字符
                    txtRealName.BulkText = Generate.GenerateChineseWords(31);

                    //点击确定按钮
                    btnComfirmAddDoctor.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("真实姓名最多30个字！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增医生，真实姓名为空|真实姓名多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增医生，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【新增医生，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医生，真实姓名为空|真实姓名多于30个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增用户，医院为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        
        public static bool AddDoctor_HospitalNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                //Button btnAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddDoctor"));
                //btnAddDoctor.Click();

                //账号名称不为空
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdDoctorPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdDoctorPwd"));
                pwdDoctorPwd.Text = "12345678";

                //账号名称不为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.BulkText = Generate.GenerateChineseWords(5);

                //此处未选择角色，即角色为空
                //ComboBox cbRole = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbRole"));
                //cbRole.Select(null);

                //点击确定按钮
                Button btnComfirmAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddDoctor"));
                btnComfirmAddDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请选择医院！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医生，医院为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医生，医院为空】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医生，医院为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医生，市场负责人为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        /// /// 新增：btnAddDoctor
        /// 账号名：txtDoctorName
        /// 密码：pwdDcotorPwd
        /// 邮箱地址：txtEmail
        /// 真实姓名：txtRealName
        /// 身份证号码：txtIDCard
        /// 所在医院：cbHospital
        /// 职务：txtPosition
        /// 手机：txtPhone
        /// 专业：txtMajor
        /// 市场负责人：txtMarketAdmin
        /// 状态：cbStauts
        /// 确定：btnComfirmAddDoctor
        /// 取消：btnCancleAddDoctor
        public static bool AddDoctor_MarkerNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                //Button btnAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddDoctor"));
                //btnAddDoctor.Click();

                //账号名称不为空
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdDoctorPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdDoctorPwd"));
                pwdDoctorPwd.Text = "12345678";

                //邮箱地址为空
                //TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                //txtEmail.Text = "";

                //选择医院
                ComboBox cbHospital = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbHospital"));
                cbHospital.Select(3);

                //点击确定按钮
                Button btnComfirmAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddDoctor"));
                btnComfirmAddDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入市场负责人！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医生，市场负责人为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医生，市场负责人为空】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医生，市场负责人为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医生成功，同时关闭新增医生窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddDoctorSucc(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                //Button btnAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddDoctor"));
                //btnAddDoctor.Click();

                //账号名称不为空
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdDoctorPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdDoctorPwd"));
                pwdDoctorPwd.Text = "12345678";

                //正确邮箱地址
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "ww@qq.com";

                //真实姓名不为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.BulkText = Generate.GenerateChineseWords(3);

                //身份证不为空
                TextBox txtIDCard = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtIDCard"));
                txtIDCard.Text = "440444199605043242";

                //选择医院
                ComboBox cbHospital = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbHospital"));
                cbHospital.Select(1);

                //职务不为空
                TextBox txtPosition = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtPosition"));
                txtPosition.BulkText = Generate.GenerateChineseWords(3);

                //手机不为空
                TextBox txtPhone = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtPhone"));
                txtPhone.Text = "13422222222";

                //专业不为空
                TextBox txtMajor = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtMajor"));
                txtMajor.BulkText = Generate.GenerateChineseWords(3);

                //市场负责人不为空
                TextBox txtMarketAdmin = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtMarketAdmin"));
                txtMarketAdmin.BulkText = Generate.GenerateChineseWords(3);

                //选择状态
                ComboBox cbStauts = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbStauts"));
                cbStauts.Select(1);

                //点击确定按钮
                Button btnComfirmAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddDoctor"));
                btnComfirmAddDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果不能捕捉到，则测试不通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("新增成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    try
                    {
                        //捕捉新增医生窗口，如果不能捕捉到，则测试通过
                        string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增医生")).ToString();

                        msg = "测试【新增医生成功，同时关闭新增医生窗口】--未通过，未关闭新增医生窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增医生成功，同时关闭新增医生窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch
                {
                    msg = "测试【新增医生成功，同时关闭新增医生窗口】-未通过。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医生成功，同时关闭新增医生窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医生，点击取消按钮，关闭新增医生窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddDoctor_ClickCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddDoctor"));
                btnAddDoctor.Click();

                //点击取消按钮
                Button btnCancleAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleAddDoctor"));
                btnCancleAddDoctor.Click();

                try
                {
                    //捕捉新增医生窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增医生")).ToString();
                    msg = "测试【新增医生，点击取消按钮，关闭新增医生窗口】--未通过，未关闭新增窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【新增医生，点击取消按钮，关闭新增医生窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医生，点击取消按钮，关闭新增医生窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region 编辑医生

        /// <summary>
        /// 编辑医生，账号名为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDoctor_DoctorNameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDoctor").AndIndex(2));
                btnEditDoctor.Click();

                //账号名称为空
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.Text = "";

                //点击确定按钮
                Button btnComfirmEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditDoctor"));
                btnComfirmEditDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入账号名！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑医生，账号名为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑医生，账号名为空】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑医生，账号名为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑医生，账号名称最少5个字|多于30个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDoctor_DoctorNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //账号名称少于1个字符
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = Generate.GenerateChineseWords(1);

                //点击确定按钮
                Button btnComfirmEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditDoctor"));
                btnComfirmEditDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名最少5个字，最多30个字！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //账号名称多于30个字符
                    txtDoctorName.BulkText = Generate.GenerateChineseWords(31);

                    //点击确定按钮
                    btnComfirmEditDoctor.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名最少5个字，最多30个字！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        //点击取消按钮，关闭编辑窗口
                        Button btnCancleEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditDoctor"));
                        btnCancleEditDoctor.Click();

                        msg = "测试【编辑医生，账号名称最少5个字|多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑医生，账号名称最少5个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑医生，账号名称最少5个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑医生，账号名称最少5个字|多于30个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑医生，不修改密码
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDoctor_NoEditPwd(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDoctor").AndIndex(2));
                btnEditDoctor.Click();

                //点击确定按钮
                Button btnComfirmEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditDoctor"));
                btnComfirmEditDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑医生，不修改密码】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑医生，不修改密码】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑医生，不修改密码】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑医生，修改密码为少于8位|多于30位
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDoctor_PwdLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDoctor").AndIndex(2));
                btnEditDoctor.Click();

                //密码少于8个字符
                TextBox pwdDoctorPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdDoctorPwd"));
                pwdDoctorPwd.Text = "123";

                //点击确定按钮
                Button btnComfirmEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditDoctor"));
                btnComfirmEditDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8位，最多30位！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //密码多于30个字符
                    pwdDoctorPwd.Text = "1233444444444444444444444444444444444444";

                    //点击确定按钮
                    btnComfirmEditDoctor.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8位，最多30位！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        //点击取消按钮，关闭编辑窗口
                        Button btnCancleEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditDoctor"));
                        btnCancleEditDoctor.Click();

                        msg = "测试【编辑医生，修改密码为少于8位|多于30位】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑医生，修改密码为少于8位|多于30位】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑医生，修改密码为少于8位|多于30位】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑医生，修改密码为少于8位|多于30位】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑医生，邮箱地址格式不正确
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDoctor_EmailError(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDoctor").AndIndex(2));
                btnEditDoctor.Click();

                //邮箱地址格式不正确
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "ff";

                //点击确定按钮
                Button btnComfirmEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditDoctor"));
                btnComfirmEditDoctor.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("邮箱地址格式不正确！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //点击取消按钮，关闭编辑窗口
                    Button btnCancleEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditDoctor"));
                    btnCancleEditDoctor.Click();

                    msg = "测试【编辑医生，邮箱地址格式不正确】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑医生，邮箱地址格式不正确】--未通过，缺少邮箱地址验证提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑医生，邮箱地址格式不正确】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑医生，真实姓名为空|真实姓名多于30个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDoctor_RealNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDoctor").AndIndex(2));
                btnEditDoctor.Click();

                //真实姓名为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.Text = "";

                //点击确定按钮
                Button btnComfirmEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditDoctor"));
                btnComfirmEditDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入真实姓名！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //真实姓名多于30个字
                    txtRealName.BulkText = Generate.GenerateChineseWords(31);

                    //点击确定按钮
                    btnComfirmEditDoctor.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("真实姓名最多30个字！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        //点击取消按钮，关闭编辑窗口
                        Button btnCancleEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditDoctor"));
                        btnCancleEditDoctor.Click();

                        msg = "测试【编辑医生，真实姓名为空|真实姓名多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑医生，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑医生，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑医生，真实姓名为空|真实姓名多于30个字符】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑医生，修改所在医院
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDoctor_EditHospital(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDoctor").AndIndex(2));
                btnEditDoctor.Click();

                //修改所在医院
                ComboBox cbHospital = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbHospital"));
                cbHospital.Select(1);

                //点击确定按钮
                Button btnComfirmEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditDoctor"));
                btnComfirmEditDoctor.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑医生，修改所在医院】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑医生，修改所在医院】--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑医生，所在医院为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑医生，修改市场负责人
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDoctor_Marker(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDoctor").AndIndex(2));
                btnEditDoctor.Click();

                //修改市场负责人
                TextBox txtMarketAdmin = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtMarketAdmin"));
                txtMarketAdmin.BulkText = Generate.GenerateChineseWords(3);

                //点击确定按钮
                Button btnComfirmEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditDoctor"));
                btnComfirmEditDoctor.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                        //关闭提醒框
                        Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                    try
                    {
                        //捕捉编辑用户窗口，如果不能捕捉到，则测试通过
                        string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑医生")).ToString();

                        msg = "测试【编辑医生市场负责人，同时关闭编辑医生窗口】--未通过，未关闭编辑排牙师窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑医生市场负责人，同时关闭编辑医生窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch
                {
                    msg = "测试【编辑医生市场负责人，同时关闭编辑医生窗口】-未通过。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑医生市场负责人，同时关闭编辑医生窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑医生成功，同时关闭编辑医生窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDoctorSucc(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDoctor").AndIndex(2));
                btnEditDoctor.Click();

                //账号名称不为空
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdDoctorPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdDoctorPwd"));
                pwdDoctorPwd.Text = "12345678";

                //正确邮箱地址
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "ww@qq.com";

                //真实姓名不为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.BulkText = Generate.GenerateChineseWords(3);

                //身份证不为空
                TextBox txtIDCard = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtIDCard"));
                txtIDCard.Text = "440444199605043242";

                //选择医院
                //修改所在医院
                ComboBox cbHospital = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbHospital"));
                cbHospital.Select(3);

                //职务不为空
                TextBox txtPosition = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtPosition"));
                txtPosition.BulkText = Generate.GenerateChineseWords(3);

                //手机不为空
                TextBox txtPhone = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtPhone"));
                txtPhone.Text = "13422222222";

                //专业不为空
                TextBox txtMajor = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtMajor"));
                txtMajor.BulkText = Generate.GenerateChineseWords(3);

                //市场负责人不为空
                TextBox txtMarketAdmin = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtMarketAdmin"));
                txtMarketAdmin.BulkText = Generate.GenerateChineseWords(3);

                //选择状态
                ComboBox cbStauts = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditDoctorView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbStauts"));
                cbStauts.Select(0);

                //点击确定按钮
                Button btnComfirmEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditDoctor"));
                btnComfirmEditDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果不能捕捉到，则测试不通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    try
                    {
                        //捕捉编辑医生窗口，如果不能捕捉到，则测试通过
                        string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑医生")).ToString();

                        msg = "测试【编辑医生成功，同时关闭编辑医生窗口】--未通过，未关闭编辑医生窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑医生成功，同时关闭编辑医生窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch
                {
                    msg = "测试【编辑医生成功，同时关闭编辑医生窗口】-未通过。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑医生成功，同时关闭编辑医生窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑医生，无修改操作，点击确定按钮
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDoctor_NoEdit(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDoctor").AndIndex(2));
                btnEditDoctor.Click();

                //点击确定按钮
                Button btnComfirmEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditDoctor"));
                btnComfirmEditDoctor.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //捕捉编辑医生窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑医生")).ToString();

                    msg = "测试【编辑医生，无修改操作，点击确定按钮】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【编辑医生，无修改操作，点击确定按钮】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑医生，无修改操作，点击确定按钮】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑医生，点击取消按钮，关闭编辑医生窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDoctor_ClickCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDoctor").AndIndex(2));
                btnEditDoctor.Click();

                //点击取消按钮
                Button btnCancleEditDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditDoctor"));
                btnCancleEditDoctor.Click();

                try
                {
                    //捕捉编辑医生窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑医生")).ToString();
                    msg = "测试【编辑医生，点击取消按钮，关闭编辑医生窗口】--未通过，未关闭编辑窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【编辑医生，点击取消按钮，关闭编辑医生窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑医生，点击取消按钮，关闭编辑医生窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region  删除医生

        /// <summary>
        /// 点击删除医生按钮，弹出提醒框，选择确定
        /// </summary>
        public static bool Del_DoctorComfirm(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                Random num = new Random();
                int i = num.Next(10, 25);//产生10到25的随机数

                //点击删除按钮
                Button btnDelDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnDelDoctor").AndIndex(2));
                btnDelDoctor.Click();

                try
                {
                    //捕捉提醒信息
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该医生？")).ToString();

                    //选择确定
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("1"));
                    btnTips.Click();

                    try
                    {
                        //捕捉提醒信息
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("删除成功！")).ToString();

                        //关闭提醒
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【点击删除医生按钮，弹出提醒框，选择确定】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【点击删除医生按钮，弹出提醒框，选择确定】--未通过，缺少删除成功提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【点击删除医生按钮，弹出提醒框，选择确定】--未通过，未询问是否删除医生。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【点击删除医生按钮，弹出提醒框，选择确定】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 点击删除医生按钮，弹出提醒框，选择取消
        /// </summary>
        public static bool Del_DoctorCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                Random num = new Random();
                int i = num.Next(10, 25);//产生10到25的随机数

                //点击删除按钮
                Button btnDelDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnDelDoctor").AndIndex(2));
                btnDelDoctor.Click();

                try
                {
                    //捕捉提醒信息
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该医生？")).ToString();

                    //选择取消
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    try
                    {
                        //捕捉提醒信息，此处能捕捉到的话，测试不通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该医生？")).ToString();

                        msg = "测试【点击删除医生按钮，弹出提醒框，选择取消】--未通过，没有关闭询问框。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                    catch
                    {
                        msg = "测试【点击删除医生按钮，弹出提醒框，选择取消】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch
                {
                    msg = "测试【点击删除医生按钮，弹出提醒框，选择取消】--未通过，未询问是否删除医生。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【点击删除医生按钮，弹出提醒框，选择取消】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion
    }
}
