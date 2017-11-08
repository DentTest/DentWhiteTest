using DentWhiteTest.Helper;
using System;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.ListBoxItems;
using System.Threading;

namespace DentWhiteTest.TestCase
{
    public class UserTest
    {
        #region 用户列表

        /// <summary>
        /// 点击用户管理菜单，加载所有用户
        /// </summary>
        public static bool Load_UserList(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //在菜单页选择用户管理
                Button tlUsersManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlUsersManagement"));
                tlUsersManagement.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询用户列表异常！")).ToString();
                    msg = "测试【点击用户管理菜单，加载所有用户】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【点击用户管理菜单，加载所有用户】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【点击用户管理菜单，加载所有用户】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入账号名称，点击查询按钮，加载该用户
        /// </summary>
        public static bool Search_UserName(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //输入账号名称
                TextBox txtSearchUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtSearchUser"));

                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SHIFT);
                Thread.Sleep(1000);
                txtSearchUser.Text = "admin";
                //appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);


                //点击查询按钮
                Button btnSearch = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearch"));
                btnSearch.Click();

                var endTime = DateTime.Now;

                try
                {
                    Thread.Sleep(300);
                    //捕捉提醒信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询用户列表异常！")).ToString();
                    msg = "测试【输入用户名称，点击查询按钮，加载该用户】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入用户名称，点击查询按钮，加载该用户】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【输入用户名称，点击查询按钮，加载该用户】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 用户名称为空，点击查询按钮，加载所有用户
        /// </summary>
        public static bool Search_UserNameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //用户名称为空
                TextBox txtSearchUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtSearchUser"));
                txtSearchUser.Text = "";

                //点击查询按钮
                Button btnSearch = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearch"));
                btnSearch.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询用户列表异常！")).ToString();
                    msg = "测试【用户名称为空，点击查询按钮，加载所有用户】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【用户名称为空，点击查询按钮，加载所有用户】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【用户名称为空，点击查询按钮，加载所有用户】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region 新增用户

        /// <summary>
        /// 新增用户，账号名称为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddUser_UserNameBull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddUser"));
                btnAddUser.Click();

                //账号名称为空
                TextBox txtUserName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                txtUserName.Text = "";

                //点击确定按钮
                Button btnComfirmAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddUser"));
                btnComfirmAddUser.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入账号名！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增用户，用户名称为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增用户，用户名称为空】--未通过，缺少账号名称空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增用户，用户名称为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增用户，账号名称最少5个字|多于30个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddUser_UserNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //账号名称少于1个字符
                TextBox txtUserName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                txtUserName.Text = "z";

                //点击确定按钮
                Button btnComfirmAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddUser"));
                btnComfirmAddUser.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名称最少5个字，最多30个字！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //账号名称多于30个字符
                    txtUserName.BulkText = Generate.GenerateChineseWords(31);

                    //点击确定按钮
                    btnComfirmAddUser.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名称最少5个字，最多30个字！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增用户，账号名称最少5个字|多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增用户，账号名称最少5个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【新增用户，账号名称最少5个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增用户，账号名称最少5个字|多于30个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增用户，密码为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddUser_PwdBull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddUser"));
                btnAddUser.Click();

                //正确账号名称
                TextBox txtUserName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                txtUserName.BulkText = Generate.GenerateChineseWords(5);

                //密码为空
                TextBox pwdUserPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdUserPwd"));
                pwdUserPwd.Text = "";

                //点击确定按钮
                Button btnComfirmAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddUser"));
                btnComfirmAddUser.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入密码！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增用户，密码为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增用户，密码为空】--未通过，缺少密码空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增用户，密码为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增用户，密码少于8位|多于30位
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddUser_PwdLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddUser"));
                btnAddUser.Click();

                //账号名称不为空
                TextBox txtUserName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                txtUserName.BulkText = Generate.GenerateChineseWords(5);

                //密码少于8位
                TextBox pwdUserPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdUserPwd"));
                pwdUserPwd.Text = "123";

                //点击确定按钮
                Button btnComfirmAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddUser"));
                btnComfirmAddUser.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8位，最多30位！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //密码多于30位
                    pwdUserPwd.Text = "1233444444444444444444444444444444444444";

                    //点击确定按钮
                    btnComfirmAddUser.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8位，最多30位！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增用户，密码少于8位|多于30位】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增用户，密码少于8位|多于30位】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【新增用户，密码少于8位|多于30位】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增用户，密码少于8位|多于30位】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增用户，邮箱地址格式不正确
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddUser_EmailError(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddUser"));
                btnAddUser.Click();

                //账号名称不为空
                TextBox txtUserName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                txtUserName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdUserPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdUserPwd"));
                pwdUserPwd.Text = "12345678";

                //邮箱地址格式不正确
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "ff";

                //点击确定按钮
                Button btnComfirmAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddUser"));
                btnComfirmAddUser.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("邮箱地址格式不正确！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增用户，邮箱地址格式不正确】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增用户，邮箱地址格式不正确】--未通过，缺少邮箱地址验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增用户，邮箱地址格式不正确】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增用户，角色为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddUser_RoleNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddUser"));
                btnAddUser.Click();

                //账号名称不为空
                TextBox txtUserName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                txtUserName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdUserPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdUserPwd"));
                pwdUserPwd.Text = "12345678";

                //邮箱地址为空
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "";

                //此处未选择角色，即角色为空
                //ComboBox cbRole = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbRole"));
                //cbRole.Select(null);

                //点击确定按钮
                Button btnComfirmAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddUser"));
                btnComfirmAddUser.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请选择角色！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增用户，角色为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增用户，角色为空】--未通过，缺少角色验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增用户，角色为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增用户，真实姓名为空|真实姓名多于30个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddUser_RealNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddUser"));
                btnAddUser.Click();

                //正确账号名称
                TextBox txtUserName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                txtUserName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdUserPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdUserPwd"));
                pwdUserPwd.Text = "12345678";

                //选择角色
                ComboBox cbRole = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbRole"));
                cbRole.Select(1);

                //真实姓名为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.Text = "";

                //点击确定按钮
                Button btnComfirmAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddUser"));
                btnComfirmAddUser.Click();

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
                    btnComfirmAddUser.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("真实姓名最多30个字！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增用户，真实姓名为空|真实姓名多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增用户，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【新增用户，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增用户，真实姓名为空|真实姓名多于30个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增用户成功，同时关闭新增用户窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddUserSucc(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddUser"));
                btnAddUser.Click();

                //账号名称不为空
                TextBox txtUserName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                txtUserName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdUserPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdUserPwd"));
                pwdUserPwd.Text = "12345678";

                //正确邮箱地址
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "ww@qq.com";

                //选择角色
                ComboBox cbRole = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbRole"));
                cbRole.Select(1);

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
                Button btnComfirmAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddUser"));
                btnComfirmAddUser.Click();

                try
                {
                    //捕捉提醒信息，如果不能捕捉到，则测试不通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("新增成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    try
                    {
                        //捕捉新增用户窗口，如果不能捕捉到，则测试通过
                        string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增用户")).ToString();

                        msg = "测试【新增用户成功，同时关闭新增用户窗口】--未通过，未关闭新增用户窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增用户成功，同时关闭新增用户窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch
                {
                    msg = "测试【新增用户成功，同时关闭新增用户窗口】-未通过。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增用户成功，同时关闭新增用户窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增用户，点击取消按钮，关闭新增用户窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddUser_ClickCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddUser"));
                btnAddUser.Click();

                //点击取消按钮
                Button btnCancleAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleAddUser"));
                btnCancleAddUser.Click();

                try
                {
                    //捕捉新增用户窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增用户")).ToString();
                    msg = "测试【新增用户，点击取消按钮，关闭新增用户窗口】--未通过，未关闭新增窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【新增用户，点击取消按钮，关闭新增用户窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增用户，点击取消按钮，关闭新增用户窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region 编辑用户

        /// <summary>
        /// 编辑用户，账号名称为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditUser_UserNameBull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditUser").AndIndex(10));
                btnEditUser.Click();

                //账号名称为空
                TextBox txtUserName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                txtUserName.Text = "";

                //点击确定按钮
                Button btnComfirmEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditUser"));
                btnComfirmEditUser.Click();

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
        public static bool EditUser_UserNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //账号名称少于1个字符
                TextBox txtUserName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                txtUserName.BulkText = Generate.GenerateChineseWords(1);

                //点击确定按钮
                Button btnComfirmEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditUser"));
                btnComfirmEditUser.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名称最少5个字，最多30个字！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //账号名称多于30个字符
                    txtUserName.BulkText = Generate.GenerateChineseWords(31);

                    //点击确定按钮
                    btnComfirmEditUser.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名称最少5个字，最多30个字！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        //点击取消按钮，关闭编辑窗口
                        Button btnCancleEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditUser"));
                        btnCancleEditUser.Click();

                        msg = "测试【编辑用户，账号名称最少5个字|多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑用户，账号名称最少5个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑用户，账号名称最少5个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑用户，账号名称最少5个字|多于30个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑用户，不修改密码
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditUser_NoEditPwd(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditUser").AndIndex(10));
                btnEditUser.Click();

                //点击确定按钮
                Button btnComfirmEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditUser"));
                btnComfirmEditUser.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑用户，不修改密码】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑用户，不修改密码】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑用户，不修改密码】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑用户，修改密码为少于8位|多于30位
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditUser_PwdLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditUser").AndIndex(10));
                btnEditUser.Click();

                //密码少于8个字符
                TextBox pwdUserPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdUserPwd"));
                pwdUserPwd.Text = "123";

                //点击确定按钮
                Button btnComfirmEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditUser"));
                btnComfirmEditUser.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8位，最多30位！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //密码多于30个字符
                    pwdUserPwd.Text = "1233444444444444444444444444444444444444";

                    //点击确定按钮
                    btnComfirmEditUser.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8位，最多30位！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        //点击取消按钮，关闭编辑窗口
                        Button btnCancleEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditUser"));
                        btnCancleEditUser.Click();

                        msg = "测试【编辑用户，修改密码为少于8位|多于30位】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑用户，修改密码为少于8位|多于30位】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑用户，修改密码为少于8位|多于30位】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑用户，修改密码为少于8位|多于30位】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑用户，邮箱地址格式不正确
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditUser_EmailError(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditUser").AndIndex(10));
                btnEditUser.Click();

                //邮箱地址格式不正确
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "ff";

                //点击确定按钮
                Button btnComfirmEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditUser"));
                btnComfirmEditUser.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("邮箱地址格式不正确！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //点击取消按钮，关闭编辑窗口
                    Button btnCancleEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditUser"));
                    btnCancleEditUser.Click();

                    msg = "测试【编辑用户，邮箱地址格式不正确】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑用户，邮箱地址格式不正确】--未通过，缺少邮箱地址验证提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑用户，邮箱地址格式不正确】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑用户，修改角色
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditUser_EditRole(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditUser").AndIndex(10));
                btnEditUser.Click();

                //修改角色
                ComboBox cbRole = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbRole"));
                cbRole.Select(1);

                //点击确定按钮
                Button btnComfirmEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditUser"));
                btnComfirmEditUser.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑用户，修改角色】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑用户，修改角色】--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑用户，角色为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑用户，真实姓名为空|真实姓名多于30个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditUser_RealNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditUser").AndIndex(10));
                btnEditUser.Click();

                //真实姓名为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.Text = "";

                //点击确定按钮
                Button btnComfirmEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditUser"));
                btnComfirmEditUser.Click();

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
                    btnComfirmEditUser.Click();

                    try
                    {
                        //捕捉提醒信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("真实姓名最多30个字！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        //点击取消按钮，关闭编辑窗口
                        Button btnCancleEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditUser"));
                        btnCancleEditUser.Click();

                        msg = "测试【编辑用户，真实姓名为空|真实姓名多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑用户，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑用户，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑用户，真实姓名为空|真实姓名多于30个字符】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑用户成功，同时关闭编辑用户窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditUserSucc(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditUser").AndIndex(10));
                btnEditUser.Click();

                //账号名称不为空
                TextBox txtUserName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                txtUserName.BulkText = Generate.GenerateChineseWords(5);

                //密码不少于8个字符
                TextBox pwdUserPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdUserPwd"));
                pwdUserPwd.Text = "12345678";

                //正确邮箱地址
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text  = "ww@qq.com";

                //选择角色
                ComboBox cbRole = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbRole"));
                cbRole.Select(1);

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
                Button btnComfirmEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditUser"));
                btnComfirmEditUser.Click();

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
                        string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑用户")).ToString();

                        msg = "测试【编辑用户成功，同时关闭编辑用户窗口】--未通过，未关闭编辑用户窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑用户成功，同时关闭编辑用户窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch
                {
                    msg = "测试【编辑用户成功，同时关闭编辑用户窗口】-未通过。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑用户成功，同时关闭编辑用户窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑用户，无修改操作，点击确定按钮
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditUser_NoEdit(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditUser").AndIndex(10));
                btnAddUser.Click();

                //点击确定按钮
                Button btnComfirmEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditUser"));
                btnComfirmEditUser.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //捕捉编辑用户窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑用户")).ToString();

                    msg = "测试【编辑用户，无修改操作，点击确定按钮】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【编辑用户，无修改操作，点击确定按钮】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑用户，无修改操作，点击确定按钮】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑用户，点击取消按钮，关闭编辑用户窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditUser_ClickCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditUser").AndIndex(10));
                btnEditUser.Click();

                //点击取消按钮
                Button btnCancleEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditUser"));
                btnCancleEditUser.Click();

                try
                {
                    //捕捉编辑用户窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑用户")).ToString();
                    msg = "测试【编辑用户，点击取消按钮，关闭编辑用户窗口】--未通过，未关闭编辑窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【编辑用户，点击取消按钮，关闭编辑用户窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑用户，点击取消按钮，关闭编辑用户窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region  删除用户

        /// <summary>
        /// 点击删除用户按钮，弹出提醒框，选择确定
        /// </summary>
        public static bool Del_UserComfirm(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                Random num = new Random();
                int i = num.Next(10, 25);//产生10到25的随机数

                //点击删除按钮
                Button btnDelUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnDelUser").AndIndex(i));
                btnDelUser.Click();

                try
                {
                    //捕捉提醒信息
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该用户？")).ToString();

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

                        msg = "测试【点击删除用户按钮，弹出提醒框，选择确定】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【点击删除用户按钮，弹出提醒框，选择确定】--未通过，缺少删除成功提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【点击删除用户按钮，弹出提醒框，选择确定】--未通过，未询问是否删除用户。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【点击删除用户按钮，弹出提醒框，选择确定】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 点击删除用户按钮，弹出提醒框，选择取消
        /// </summary>
        public static bool Del_UserCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                Random num = new Random();
                int i = num.Next(10, 25);//产生10到25的随机数

                //点击删除按钮
                Button btnDelUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnDelUser").AndIndex(i));
                btnDelUser.Click();

                try
                {
                    //捕捉提醒信息
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该用户？")).ToString();

                    //选择取消
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    try
                    {
                        //捕捉提醒信息，此处能捕捉到的话，测试不通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该用户？")).ToString();

                        msg = "测试【点击删除用户按钮，弹出提醒框，选择取消】--未通过，没有关闭询问框。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                    catch
                    {
                        msg = "测试【点击删除用户按钮，弹出提醒框，选择取消】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch
                {
                    msg = "测试【点击删除用户按钮，弹出提醒框，选择取消】--未通过，未询问是否删除用户。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【点击删除用户按钮，弹出提醒框，选择取消】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion
    }
}
