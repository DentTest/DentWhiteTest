using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.ListBoxItems;
using DentWhiteTest.Helper;
using System;

namespace DentWhiteTest.TestCase
{
    public class FactoryTechnicianTest
    {
        #region 技师列表

        /// <summary>
        /// 点击技师管理菜单，加载所有技师
        /// </summary>
        public static bool Load_TechnicianList(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //在菜单页选择技师管理
                Button tlTechnicianManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlTechnicianManagement"));
                tlTechnicianManagement.Click();
                var endTime = DateTime.Now;

                msg = "测试【点击技师管理菜单，加载所有技师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                return true;
            }
            catch (Exception e)
            {
                msg = "测试【点击技师管理菜单，加载所有技师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入技师名称，点击查询按钮，加载该技师
        /// </summary>
        public static bool Search_TechnicianName(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //输入账号名称：txtTechnicianAccount
                TextBox txtTechnicianAccount = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianAccount"));
                txtTechnicianAccount.Text = "bwl";

                //点击查询按钮
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                var endTime = DateTime.Now;

                try
                {
                    Thread.Sleep(300);
                    //捕捉提醒信息，如果能铺捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询技师列表异常！")).ToString();
                    msg = "测试【输入技师名称，点击查询按钮，加载该技师】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【输入技师名称，点击查询按钮，加载该技师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【输入技师名称，点击查询按钮，加载该技师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入技师姓名，点击查询按钮，加载该技师
        /// </summary>
        public static bool Search_TechnicianUserName(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //清空账号
                TextBox txtTechnicianAccount = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianAccount"));
                txtTechnicianAccount.Text = "";

                //输入技师姓名
                TextBox txtName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtName"));
                txtName.Text = "ybc";
                //appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);

                //点击查询按钮
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();
                var endTime = DateTime.Now;
                try
                {
                    Thread.Sleep(300);
                    //捕捉提醒信息，如果能铺捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询技师列表异常！")).ToString();
                    msg = "测试【输入技师姓名，点击查询按钮，加载该技师】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【输入技师姓名，点击查询按钮，加载该技师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【输入技师姓名，点击查询按钮，加载该技师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 选择在线查询技师，点击查询按钮，加载所有在线的技师
        /// </summary>
        public static bool Search_TechnicianOnline(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //技师姓名清空
                TextBox txtName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtName"));
                txtName.Text = "";
                
                //选择在线的技师
                ComboBox cbIsOnline = appWin.Get<ComboBox>(SearchCriteria.ByAutomationId("cbIsOnline"));
                cbIsOnline.Select(2);


                //点击查询按钮
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                var endTime = DateTime.Now;

                try
                {
                    Thread.Sleep(300);
                    //捕捉提醒信息，如果能铺捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询技师列表异常！")).ToString();
                    msg = "测试【选择在线技师，点击查询按钮，加载在线技师】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【选择在线技师，点击查询按钮，加载在线技师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【选择在线技师，点击查询按钮，加载在线技师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 选择不在线查询技师，点击查询按钮，加载所有不在线的技师
        /// </summary>
        public static bool Search_TechnicianOnline2(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //选择不在线的技师
                ComboBox cbIsOnline = appWin.Get<ComboBox>(SearchCriteria.ByAutomationId("cbIsOnline"));
                cbIsOnline.Select(1);
                //点击查询按钮
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();
                var endTime = DateTime.Now;
                try
                {
                    Thread.Sleep(300);
                    //捕捉提醒信息，如果能铺捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询技师列表异常！")).ToString();
                    msg = "测试【选择不在线的技师，点击查询按钮，加载不在线的技师】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【选择不在线的技师，点击查询按钮，加载不在线的技师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【选择不在线的技师，点击查询按钮，加载不在线的技师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 账号名称和技师名称为空，点击查询按钮，加载所有技师
        /// </summary>
        public static bool Search_TechnicianNameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //技师名称为空
                //TextBox txtDentureAccount = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtDentureAccount"));
                //txtDentureAccount.Text = "";
                //appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);

                ComboBox cbIsOnline = appWin.Get<ComboBox>(SearchCriteria.ByAutomationId("cbIsOnline"));
                cbIsOnline.Select(0);
                //点击查询按钮
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();


                var endTime = DateTime.Now;

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询技师列表异常！")).ToString();
                    msg = "测试【技师名称为空，点击查询按钮，加载所有技师】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【技师名称为空，点击查询按钮，加载所有技师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【技师名称为空，点击查询按钮，加载所有技师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region 新增技师
        /// <summary>
        /// 新增技师，账号名称为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        /// 新增按钮：btnAddTechnician
        /// 编辑文本：txtTechnicianName
        /// 密码：pwdTechnicianPwd
        /// 邮箱地址：txtEmail
        /// 真是姓名：txtRealName
        /// 身份证：txtIDCard
        /// 职务：txtDuty
        /// 手机号：txtTel
        /// 启用：cbStauts
        /// 确定：btnComfirmAddTechnician
        /// 取消：btnCancleAddTechnician
        /// 子窗体：AddOrEditUserView
        public static bool AddTechnician_UserNameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddTechnician"));
                btnAddTechnician.Click();

                //账号名称为空
                TextBox txtTechnicianName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianName"));
                txtTechnicianName.Text = "";

                //点击确定按钮
                Button btnComfirmAddTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddTechnician"));
                btnComfirmAddTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入账号名！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增技师，账号名称为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增技师，账号名称为空】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技师，账号名称为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑用户，账号名称最少5个字|多于30个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddTechnician_UserNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //账号名称少于5个字符
                TextBox txtTechnicianName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianName"));
                txtTechnicianName.BulkText = Generate.GenerateChineseWords(4);

                //点击确定按钮
                Button btnComfirmAddTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddTechnician"));
                btnComfirmAddTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名称最少5个字，最多30个字！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //账号名称多于30个字符
                    txtTechnicianName.BulkText = Generate.GenerateChineseWords(31);

                    //点击确定按钮
                    btnComfirmAddTechnician.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名称最少5个字，最多30个字！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增技师，账号名称最少5个字|多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增技师，账号名称最少5个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【新增技师，账号名称最少5个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技师，账号名称最少5个字|多于30个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技师，密码为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddTechnician_PwdNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //账号名称
                TextBox txtTechnicianName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianName"));
                txtTechnicianName.BulkText = Generate.GenerateChineseWords(6);

                //输入真实姓名
                TextBox pwdTechnicianPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdTechnicianPwd"));
                pwdTechnicianPwd.Text = "";

                //点击确定按钮
                Button btnComfirmAddTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddTechnician"));
                btnComfirmAddTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入密码！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增技师，密码为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增技师，密码为空】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技师，密码为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技师，密码少于8位|多于30位
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddTechnician_PwdLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //账号名称
                TextBox txtTechnicianName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianName"));
                txtTechnicianName.BulkText = Generate.GenerateChineseWords(6);

                //输入密码
                TextBox pwdTechnicianPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdTechnicianPwd"));
                pwdTechnicianPwd.Text = "1234567";

                //点击确定按钮
                Button btnComfirmAddTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddTechnician"));
                btnComfirmAddTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8位，最多30位！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //密码多于30位
                    pwdTechnicianPwd.Text = "1233444444444444444444444444444444444444";

                    //点击确认
                    btnComfirmAddTechnician.Click();
                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8位，最多30位！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增技师，密码少于8位|多于30位】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                {
                    msg = "测试【新增技师，密码少于8位|多于30位】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
                catch
                {
                    msg = "测试【新增技师，密码少于8位|多于30位】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技师，密码少于8位|多于30位】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技师，邮箱地址格式不正确
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddTechnician_EmailError(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                //Button btnAddTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddTechnician").AndIndex(10));
                //btnAddTechnician.Click();

                //账号名称
                TextBox txtTechnicianName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianName"));
                txtTechnicianName.BulkText = Generate.GenerateChineseWords(6);

                //输入密码
                TextBox pwdTechnicianPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdTechnicianPwd"));
                pwdTechnicianPwd.Text = "123456789";

                //邮箱地址格式不正确
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "ff";

                //点击确定按钮
                Button btnComfirmAddTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddTechnician"));
                btnComfirmAddTechnician.Click();

                //var endTime = DateTime.Now;
                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("邮箱地址格式不正确！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增技师，邮箱地址格式不正确】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增技师，邮箱地址格式不正确】--未通过，缺少邮箱地址验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技师，邮箱地址格式不正确】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技师，真实姓名为空|真实姓名多于30个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddTechnician_RealNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //正确账号名称
                TextBox txtTechnicianName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianName"));
                txtTechnicianName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdTechnicianPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdTechnicianPwd"));
                pwdTechnicianPwd.Text = "12345678";

                // 邮箱地址格式不正确
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "";

                //真实姓名为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.Text = "";

                //点击确定按钮
                Button btnComfirmAddTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddTechnician"));
                btnComfirmAddTechnician.Click();

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
                    btnComfirmAddTechnician.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("真实姓名最多30个字！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增技师，真实姓名为空|真实姓名多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增技师，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【新增技师，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技师，真实姓名为空|真实姓名多于30个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技师，身份证不为空|身份证格式不正确
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddTechnician_IDcard(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //正确账号名称
                TextBox txtTechnicianName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianName"));
                txtTechnicianName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdTechnicianPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdTechnicianPwd"));
                pwdTechnicianPwd.Text = "12345678";

                // 邮箱地址格式不正确
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "";

                //真实姓名为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.Text = "你好啊";

                //身份证不为空
                TextBox txtIDCard = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtIDCard"));
                txtIDCard.Text = "";

                //点击确定按钮
                Button btnComfirmAddTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddTechnician"));
                btnComfirmAddTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请填写身份证号码！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //身份证格式不正确
                    txtIDCard.Text = "440883199402";

                    btnComfirmAddTechnician.Click();

                    try
                    {
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("身份证号码格式不正确！")).ToString();
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增技师，身份证格式不正确】--通过,用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch {
                        msg = "测试【新增技师，身份证格式不正确】--未通过,缺少身份证格式验证，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【新增技师，身份证格式不正确】--未通过，缺少身份证号码验证，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技师，身份证格式不正确】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技师，手机号码为空|手机号码格式不正确
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddTechnician_Phone(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //正确账号名称
                TextBox txtTechnicianName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianName"));
                txtTechnicianName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdTechnicianPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdTechnicianPwd"));
                pwdTechnicianPwd.Text = "12345678";

                // 邮箱地址格式
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "";

                //真实姓名为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.Text = "你好啊";

                //身份证不为空
                TextBox txtIDCard = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtIDCard"));
                txtIDCard.Text = "440883199509080706";

                //点击确定按钮
                Button btnComfirmAddTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddTechnician"));
                btnComfirmAddTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请填写手机号码！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //手机不正确
                    TextBox txtTel = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTel"));
                    txtTel.Text = "134222222";

                    btnComfirmAddTechnician.Click();

                    try
                    {
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("手机号码格式不正确！")).ToString();
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增技师，手机号码格式不正确】--通过,用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增技师，手机号码格式不正确】--未通过,缺少身份证格式验证，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【新增技师，手机号码格式不正确】--未通过，缺少身份证号码验证，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技师，手机号码格式不正确】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技师成功，同时关闭编辑用户窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddTechnicianSucc(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                ///正确账号名称
                TextBox txtTechnicianName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianName"));
                txtTechnicianName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdTechnicianPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdTechnicianPwd"));
                pwdTechnicianPwd.Text = "12345678";

                // 邮箱地址格式不正确
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "";

                //真实姓名为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.BulkText =Generate.GenerateChineseWords(4);

                //身份证不为空
                TextBox txtIDCard = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtIDCard"));
                txtIDCard.Text = "440444199605043242";

                //职务不为空
                TextBox txtDuty = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDuty"));
                txtDuty.BulkText = Generate.GenerateChineseWords(3);

                //手机不为空
                TextBox txtTel = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTel"));
                txtTel.Text = "13422222222";

                TextBox txtMarketAdmin = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtMarketAdmin"));
                txtMarketAdmin.Text = "你好啊";

                //选择状态
                ComboBox cbStauts = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbStauts"));
                cbStauts.Select(1);

                //点击确定按钮
                Button btnComfirmAddTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddTechnician"));
                btnComfirmAddTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果不能捕捉到，则测试不通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("新增成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    try
                    {
                        //捕捉编辑用户窗口，如果不能捕捉到，则测试通过
                        string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增技师")).ToString();

                        msg = "测试【新增技师成功，同时关闭新增技师窗口】--未通过，未关闭新增技师窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增技师成功，同时关闭新增技师窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch
                {
                    msg = "测试【新增技师成功，同时关闭新增技师窗口】-未通过。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技师成功，同时关闭新增技师窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技师，点击取消按钮，关闭新增技师窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddTechnician_ClickCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddTechnician"));
                btnAddTechnician.Click();

                //点击取消按钮
                Button btnCancleAddTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleAddTechnician"));
                btnCancleAddTechnician.Click();

                try
                {
                    //捕捉新增技师窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增技师")).ToString();
                    msg = "测试【新增技师，点击取消按钮，关闭新增技师窗口】--未通过，未关闭编辑窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【新增技师，点击取消按钮，关闭新增技师窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技师，点击取消按钮，关闭新增技师窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region 编辑技师
        /// <summary>
        /// 编辑技师，账号名称为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        /// 编辑按钮：btnEditTechnician
        /// 编辑文本：txtTechnicianName
        /// 密码：pwdTechnicianPwd
        /// 邮箱地址：txtEmail
        /// 真是姓名：txtRealName
        /// 身份证：txtIDCard
        /// 职务：txtDuty
        /// 手机号：txtTel
        /// 启用：cbStauts
        /// 确定：btnComfirmEditTechnician
        /// 取消：btnCancleEditTechnician
        /// 子窗体：AddOrEditUserView
        public static bool EditTechnician_UserNameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditTechnician").AndIndex(5));
                btnEditTechnician.Click();

                //账号名称为空
                TextBox txtTechnicianName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianName"));
                txtTechnicianName.Text = "";

                //点击确定按钮
                Button btnComfirmEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditTechnician"));
                btnComfirmEditTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入账号名！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑用户，账号名称为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑用户，账号名称为空】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑用户，账号名称为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑用户，账号名称最少5个字|多于30个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditTechnician_UserNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //账号名称少于1个字符
                TextBox txtTechnicianName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianName"));
                txtTechnicianName.BulkText = Generate.GenerateChineseWords(1);

                //点击确定按钮
                Button btnComfirmEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditTechnician"));
                btnComfirmEditTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名称最少5个字，最多30个字！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //账号名称多于30个字符
                    txtTechnicianName.BulkText = Generate.GenerateChineseWords(31);

                    //点击确定按钮
                    btnComfirmEditTechnician.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名称最少5个字，最多30个字！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        //点击取消按钮，关闭编辑窗口
                        Button btnCancleEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditTechnician"));
                        btnCancleEditTechnician.Click();

                        msg = "测试【编辑技师，账号名称最少5个字|多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑技师，账号名称最少5个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑技师，账号名称最少5个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技师，账号名称最少5个字|多于30个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技师，不修改密码
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditTechnician_NoEditPwd(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditTechnician").AndIndex(5));
                btnEditTechnician.Click();

                //输入真实姓名
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.Text = "1234";

                //点击确定按钮
                Button btnComfirmEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditTechnician"));
                btnComfirmEditTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑技师，不修改密码】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑技师，不修改密码】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技师，不修改密码】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技师，修改密码为少于8位|多于30位
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditTechnician_PwdLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditTechnician").AndIndex(5));
                btnEditTechnician.Click();

                //密码少于8个字符
                TextBox pwdTechnicianPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdTechnicianPwd"));
                pwdTechnicianPwd.Text = "123";

                //点击确定按钮
                Button btnComfirmEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditTechnician"));
                btnComfirmEditTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8位，最多30位！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //密码多于30个字符
                    pwdTechnicianPwd.Text = "1233444444444444444444444444444444444444";

                    //点击确定按钮
                    btnComfirmEditTechnician.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8位，最多30位！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        //点击取消按钮，关闭编辑窗口
                        Button btnCancleEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditTechnician"));
                        btnCancleEditTechnician.Click();

                        msg = "测试【编辑技师，修改密码为少于8位|多于30位】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑技师，修改密码为少于8位|多于30位】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑技师，修改密码为少于8位|多于30位】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技师，修改密码为少于8位|多于30位】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技师，邮箱地址格式不正确
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditTechnician_EmailError(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditTechnician").AndIndex(5));
                btnEditTechnician.Click();

                //邮箱地址格式不正确
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "ff";

                //点击确定按钮
                Button btnComfirmEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditTechnician"));
                btnComfirmEditTechnician.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("邮箱地址格式不正确！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //点击取消按钮，关闭编辑窗口
                    Button btnCancleEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditTechnician"));
                    btnCancleEditTechnician.Click();

                    msg = "测试【编辑技师，邮箱地址格式不正确】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑技师，邮箱地址格式不正确】--未通过，缺少邮箱地址验证提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技师，邮箱地址格式不正确】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技师，修改状态
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditTechnician_EditRole(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                Random num = new Random();
                int i = num.Next(10, 25);//产生10到25的随机数

                //点击编辑按钮
                Button btnEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditTechnician").AndIndex(5));
                btnEditTechnician.Click();

                //修改状态
                ComboBox cbStauts = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbStauts"));
                cbStauts.Select(1);

                //点击确定按钮
                Button btnComfirmEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditTechnician"));
                btnComfirmEditTechnician.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑技师，修改角色】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑技师，修改角色】--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技师，角色为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技师，真实姓名为空|真实姓名多于30个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditTechnician_RealNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditTechnician").AndIndex(5));
                btnEditTechnician.Click();

                //真实姓名为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.Text = "";

                //点击确定按钮
                Button btnComfirmEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditTechnician"));
                btnComfirmEditTechnician.Click();

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
                    btnComfirmEditTechnician.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("真实姓名最多30个字！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        //点击取消按钮，关闭编辑窗口
                        Button btnCancleEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditTechnician"));
                        btnCancleEditTechnician.Click();

                        msg = "测试【编辑技师，真实姓名为空|真实姓名多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑技师，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑技师，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技师，真实姓名为空|真实姓名多于30个字符】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技师，手机号码为空|手机号码格式不正确
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditTechnician_Phone(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //手机号码为空
                TextBox txtTel = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTel"));
                txtTel.Text = "";

                //点击确定按钮
                Button btnComfirmEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddTechnician"));
                btnComfirmEditTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请填写手机号码！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //手机不正确
                    txtTel = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTel"));
                    txtTel.Text = "1342222";

                    btnComfirmEditTechnician.Click();

                    try
                    {
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("手机号码格式不正确！")).ToString();
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【编辑技师，手机号码格式不正确】--通过,用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑技师，手机号码格式不正确】--未通过,缺少手机号码格式验证，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑技师，手机号码格式不正确】--未通过，缺少手机号码验证，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技师，手机号码格式不正确】--失败，原因：" + e.ToString();
                return false;
            }
        }


        /// <summary>
        /// 编辑技师，身份证不为空|身份证格式不正确
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditTechnician_IDCard(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditTechnician").AndIndex(5));
                btnEditTechnician.Click();

                //身份证为空
                TextBox txtIDCard = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtIDCard"));
                txtIDCard.Text = "";

                //点击确定按钮
                Button btnComfirmEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditTechnician"));
                btnComfirmEditTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请填写身份证号码！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //身份证格式不正确
                    txtIDCard.Text = "44088319980809";

                    btnComfirmEditTechnician.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("身份证号码格式不正确！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        //点击取消按钮，关闭编辑窗口
                        Button btnCancleEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditTechnician"));
                        btnCancleEditTechnician.Click();

                        msg = "测试【编辑技师，身份证不为空|身份证格式不正确】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑技师，身份证不为空|身份证格式不正确】--未通过，缺少身份证格式验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑技师，身份证不为空|身份证格式不正确】--未通过，缺少身份证空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技师，身份证不为空|身份证格式不正确】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技师成功，同时关闭编辑用户窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditTechnicianSucc(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditTechnician").AndIndex(5));
                btnEditTechnician.Click();

                //账号名称不为空
                TextBox txtTechnicianName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTechnicianName"));
                txtTechnicianName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdTechnicianPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdTechnicianPwd"));
                pwdTechnicianPwd.Text = "12345678";

                //正确邮箱地址
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "ww@qq.com";

                //真实姓名不为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.BulkText = Generate.GenerateChineseWords(3);

                //身份证不为空
                TextBox txtIDCard = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtIDCard"));
                txtIDCard.Text = "440444199605043242";

                //职务不为空
                TextBox txtDuty = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDuty"));
                txtDuty.BulkText = Generate.GenerateChineseWords(3);

                //手机不为空
                TextBox txtTel = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTel"));
                txtTel.Text = "13422222222";

                //选择状态
                ComboBox cbStauts = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbStauts"));
                cbStauts.Select(0);


                //点击确定按钮
                Button btnComfirmEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditTechnician"));
                btnComfirmEditTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果不能捕捉到，则测试不通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    try
                    {
                        //捕捉编辑用户窗口，如果不能捕捉到，则测试通过
                        string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑技师")).ToString();

                        msg = "测试【编辑技师成功，同时关闭编辑技师窗口】--未通过，未关闭编辑技师窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑技师成功，同时关闭编辑技师窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch
                {
                    msg = "测试【编辑技师成功，同时关闭编辑技师窗口】-未通过。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技师成功，同时关闭编辑技师窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技师，无修改操作，点击确定按钮
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditTechnician_NoEdit(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditTechnician").AndIndex(5));
                btnEditTechnician.Click();

                //点击确定按钮
                Button btnComfirmEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditTechnician"));
                btnComfirmEditTechnician.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //捕捉编辑用户窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑技师")).ToString();

                    msg = "测试【编辑技师，无修改操作，点击确定按钮】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【编辑技师，无修改操作，点击确定按钮】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技师，无修改操作，点击确定按钮】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技师，点击取消按钮，关闭编辑技师窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditTechnician_ClickCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditTechnician").AndIndex(5));
                btnEditTechnician.Click();

                //点击取消按钮
                Button btnCancleEditTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditTechnician"));
                btnCancleEditTechnician.Click();

                try
                {
                    //捕捉编辑技师窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑技师")).ToString();
                    msg = "测试【编辑技师，点击取消按钮，关闭编辑技师窗口】--未通过，未关闭编辑窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【编辑技师，点击取消按钮，关闭编辑技师窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技师，点击取消按钮，关闭编辑技师窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region  删除技师

        /// <summary>
        /// 点击删除技师按钮，弹出提醒框，选择确定
        /// </summary>
        public static bool Del_TechnicianComfirm(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                Random num = new Random();
                int i = num.Next(10, 25);//产生10到25的随机数

                //点击删除按钮
                Button btnDelTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnDelTechnician").AndIndex(5));
                btnDelTechnician.Click();

                try
                {
                    //捕捉提醒信息
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该技师？")).ToString();

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

                        msg = "测试【点击删除技师按钮，弹出提醒框，选择确定】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【点击删除技师按钮，弹出提醒框，选择确定】--未通过，缺少删除成功提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【点击删除技师按钮，弹出提醒框，选择确定】--未通过，未询问是否删除技师。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【点击删除技师按钮，弹出提醒框，选择确定】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 点击删除技师按钮，弹出提醒框，选择取消 btnDelTechnician
        /// </summary>
        public static bool Del_TechnicianCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                Random num = new Random();
                int i = num.Next(10, 25);//产生10到25的随机数

                //点击删除按钮
                Button btnDelTechnician = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnDelTechnician").AndIndex(5));
                btnDelTechnician.Click();

                try
                {
                    //捕捉提醒信息
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该技师？")).ToString();

                    //选择取消
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    try
                    {
                        //捕捉提醒信息，此处能捕捉到的话，测试不通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该技师？")).ToString();

                        msg = "测试【点击删除技师按钮，弹出提醒框，选择取消】--未通过，没有关闭询问框。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                    catch
                    {
                        msg = "测试【点击删除技师按钮，弹出提醒框，选择取消】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch
                {
                    msg = "测试【点击删除技师按钮，弹出提醒框，选择取消】--未通过，未询问是否删除用户。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【点击删除技师按钮，弹出提醒框，选择取消】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

    }
}
