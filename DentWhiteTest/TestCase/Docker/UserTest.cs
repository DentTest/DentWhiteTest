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
                    //捕捉报错信息，如果能捕捉到，则测试未通过
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
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);


                //点击查询按钮
                Button btnSearch = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearch"));
                btnSearch.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
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
                    //捕捉报错信息，如果能捕捉到，则测试未通过
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

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入账号名！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增用户，用户名称为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增用户，用户名称为空】--未通过，缺少账号名称空验证提醒。用时：" + (endTime - startTime).TotalSeconds;
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
        /// 新增用户，账号名称少于2个字符|多于30个字符
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
                txtUserName.BulkText = Generate.GenerateChineseWords(1);

                //点击确定按钮
                Button btnComfirmAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddUser"));
                btnComfirmAddUser.Click();

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名称最少2个字符，最多30个字符！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //账号名称多于30个字符
                    txtUserName.BulkText = Generate.GenerateChineseWords(31);

                    //点击确定按钮
                    btnComfirmAddUser.Click();

                    try
                    {
                        //捕捉报错信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名称最少2个字符，最多30个字符！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增用户，账号名称少于2个字符|多于30个字符】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增用户，账号名称少于2个字符|多于30个字符】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【新增用户，账号名称少于2个字符|多于30个字符】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增用户，账号名称少于2个字符|多于30个字符】--失败，原因：" + e.ToString();
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
                txtUserName.BulkText = Generate.GenerateChineseWords(3);

                //密码为空
                TextBox pwdUserPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdUserPwd"));
                pwdUserPwd.Text = "";

                //点击确定按钮
                Button btnComfirmAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddUser"));
                btnComfirmAddUser.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入密码！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增用户，密码为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增用户，密码为空】--未通过，缺少密码空验证提醒。用时：" + (endTime - startTime).TotalSeconds;
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
        /// 新增用户，密码少于8个字符|多于30个字符
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
                txtUserName.BulkText = Generate.GenerateChineseWords(3);

                //密码少于8个字符
                TextBox pwdUserPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdUserPwd"));
                pwdUserPwd.Text = "123";

                //点击确定按钮
                Button btnComfirmAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddUser"));
                btnComfirmAddUser.Click();

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8个字符，最多30个字符！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //密码多于30个字符
                    pwdUserPwd.Text = "1233444444444444444444444444444444444444";

                    //点击确定按钮
                    btnComfirmAddUser.Click();

                    try
                    {
                        //捕捉报错信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("密码最少8个字符，最多30个字符！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增用户，密码少于8个字符|多于30个字符】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增用户，密码少于8个字符|多于30个字符】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【新增用户，密码少于8个字符|多于30个字符】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增用户，密码少于8个字符|多于30个字符】--失败，原因：" + e.ToString();
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
                txtUserName.BulkText = Generate.GenerateChineseWords(3);

                //密码不少于8个字符
                TextBox pwdUserPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdUserPwd"));
                pwdUserPwd.Text = "12345678";

                //邮箱地址格式不正确
                TextBox txtEmail = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
                txtEmail.Text = "ff";

                //点击确定按钮
                Button btnComfirmAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddUser"));
                btnComfirmAddUser.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("邮箱地址格式不正确！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增用户，邮箱地址格式不正确】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增用户，邮箱地址格式不正确】--未通过，缺少邮箱地址验证提醒。用时：" + (endTime - startTime).TotalSeconds;
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
                txtUserName.BulkText = Generate.GenerateChineseWords(3);

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

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请选择角色！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增用户，角色为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增用户，角色为空】--未通过，缺少角色验证提醒。用时：" + (endTime - startTime).TotalSeconds;
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
        /// 新增用户，真实姓名为空|真实姓名多于30个字符
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
                txtUserName.BulkText = Generate.GenerateChineseWords(3);

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
                    //捕捉报错信息，如果能捕捉到，则测试通过
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
                        //捕捉报错信息，如果能捕捉到，则测试通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("真实姓名最多30个字符！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        msg = "测试【新增用户，真实姓名为空|真实姓名多于30个字符】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增用户，真实姓名为空|真实姓名多于30个字符】--未通过，缺少真实姓名长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【新增用户，真实姓名为空|真实姓名多于30个字符】--未通过，缺少真实姓名空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增用户，真实姓名为空|真实姓名多于30个字符】--失败，原因：" + e.ToString();
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
                txtUserName.BulkText = Generate.GenerateChineseWords(3);

                //密码不少于8个字符
                TextBox pwdUserPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdUserPwd"));
                pwdUserPwd.Text = "12345678";

                //选择角色
                ComboBox cbRole = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbRole"));
                cbRole.Select(1);

                //真实姓名不为空
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.BulkText = Generate.GenerateChineseWords(3);

                //点击确定按钮
                Button btnComfirmAddUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddUser"));
                btnComfirmAddUser.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果不能捕捉到，则测试不通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("新增成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    try
                    {
                        //捕捉新增用户窗口，如果不能捕捉到，则测试通过
                        string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增用户")).ToString();

                        msg = "测试【新增用户成功，同时关闭新增用户窗口】--未通过，未关闭新增用户窗口。用时：" + (endTime - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增用户成功，同时关闭新增用户窗口】--通过，用时：" + (endTime - startTime).TotalSeconds;
                        return true;
                    }

                }
                catch
                {
                    msg = "测试【新增用户成功，同时关闭新增用户窗口】-未通过。用时：" + (endTime - startTime).TotalSeconds;
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

                var endTime = DateTime.Now;

                try
                {
                    //捕捉新增用户窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增用户")).ToString();
                    msg = "测试【新增用户，点击取消按钮，关闭新增用户窗口】--未通过，未关闭新增窗口。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【新增用户，点击取消按钮，关闭新增用户窗口】--通过，用时：" + (endTime - startTime).TotalSeconds;
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
    }
}
