using System;
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

namespace DentWhiteTest.TestCase
{
    public class DockerTest
    {
        #region 排牙师列表

        /// <summary>
        /// 点击排牙师管理菜单，加载所有排牙师
        /// </summary>
        public static bool Load_DockerList(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //在菜单页选择排牙师管理
                Button tlDockerManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlDockerManagement"));
                tlDockerManagement.Click();
                var endTime = DateTime.Now;

                msg = "测试【点击排牙师管理菜单，加载所有排牙师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                return true;
            }
            catch (Exception e)
            {
                msg = "测试【点击排牙师管理菜单，加载所有排牙师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入排牙师名称，点击查询按钮，加载该排牙师
        /// </summary>
        public static bool Search_DockerName(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //输入排牙师名称
                TextBox txtDockerAccount = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtDockerAccount"));

                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SHIFT);
                Thread.Sleep(1000);
                txtDockerAccount.Text = "dent";
                //appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);

                //点击查询按钮
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                var endTime = DateTime.Now;

                try
                {
                    Thread.Sleep(300);
                    //捕捉提醒信息，如果能铺捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询排牙师列表异常！")).ToString();
                    msg = "测试【输入排牙师名称，点击查询按钮，加载该排牙师】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入排牙师名称，点击查询按钮，加载该排牙师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }

                
            }
            catch (Exception e)
            {
                msg = "测试【输入排牙师名称，点击查询按钮，加载该排牙师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入排牙师姓名，点击查询按钮，加载该排牙师
        /// </summary>
        public static bool Search_DockerUserName(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //输入排牙师姓名
                TextBox txtName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtName"));

                //appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SHIFT);
                //Thread.Sleep(1000);
                txtName.Text = "001";
                //appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);

                //点击查询按钮
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                var endTime = DateTime.Now;

                try
                {
                    Thread.Sleep(300);
                    //捕捉提醒信息，如果能铺捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询排牙师列表异常！")).ToString();
                    msg = "测试【输入排牙师姓名，点击查询按钮，加载该排牙师】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入排牙师姓名，点击查询按钮，加载该排牙师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }


            }
            catch (Exception e)
            {
                msg = "测试【输入排牙师姓名，点击查询按钮，加载该排牙师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 选择在线查询排牙师，点击查询按钮，加载所有在线的排牙师
        /// </summary>
        public static bool Search_DockerOnline(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //排牙师姓名清空
                TextBox txtName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtName"));
                txtName.Text = "";
                //选择在线的排牙师

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
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询排牙师列表异常！")).ToString();
                    msg = "测试【选择在线排牙师，点击查询按钮，加载在线排牙师】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【选择在线排牙师，点击查询按钮，加载在线排牙师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }


            }
            catch (Exception e)
            {
                msg = "测试【选择在线排牙师，点击查询按钮，加载在线排牙师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 选择不在线查询排牙师，点击查询按钮，加载所有不在线的排牙师
        /// </summary>
        public static bool Search_DockerOnline2(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //选择不在线的排牙师
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
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询排牙师列表异常！")).ToString();
                    msg = "测试【选择不在线的排牙师，点击查询按钮，加载不在线的排牙师】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【选择不在线的排牙师，点击查询按钮，加载不在线的排牙师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }


            }
            catch (Exception e)
            {
                msg = "测试【选择不在线的排牙师，点击查询按钮，加载不在线的排牙师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 排牙师名称为空，点击查询按钮，加载所有排牙师
        /// </summary>
        public static bool Search_DockerNameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //排牙师名称为空
                TextBox txtDockerAccount = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtDockerAccount"));

                //appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SHIFT);
                //Thread.Sleep(1000);
                txtDockerAccount.Text = "";
                //appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);

                //点击查询按钮
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();


                var endTime = DateTime.Now;

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询排牙师列表异常！")).ToString();
                    msg = "测试【排牙师名称为空，点击查询按钮，加载所有排牙师】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【排牙师名称为空，点击查询按钮，加载所有排牙师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【排牙师名称为空，点击查询按钮，加载所有排牙师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入排牙师姓名，点击查询按钮，加载该排牙师
        /// </summary>
        public static bool Search_DockerUser_Name(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //输入排牙师名称
                TextBox txtDockerAccount = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtDockerAccount"));

                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SHIFT);
                Thread.Sleep(1000);
                txtDockerAccount.Text = "dent";

                //输入排牙师姓名
                TextBox txtName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtName"));
                txtName.Text = "001";

                //选择不在线的排牙师
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
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询排牙师列表异常！")).ToString();
                    msg = "测试【输入排牙师名称和姓名，点击查询按钮，加载该排牙师】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入排牙师名称和姓名，点击查询按钮，加载该排牙师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }


            }
            catch (Exception e)
            {
                msg = "测试【输入排牙师名称和姓名，点击查询按钮，加载该排牙师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region 编辑排牙师
        /// <summary>
        /// 编辑排牙师，账号名称为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        /// 编辑按钮：btnEditDocker
        /// 编辑文本：txtUserName
        /// 密码：pwdUserPwd
        /// 邮箱地址：txtEmail
        /// 真是姓名：txtRealName
        /// 身份证：txtIDCard
        /// 职务：txtDuty
        /// 手机号：txtTel
        /// 启用：cbStauts
        /// 确定：btnComfirmEditUser
        /// 取消：btnCancleEditUser
        /// 子窗体：btnComfirmEditUser
        public static bool EditDocker_UserNameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDocker = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDocker").AndIndex(10));
                btnEditDocker.Click();

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
        /// 编辑用户，账号名称少于2个字|多于30个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDocker_UserNameLength(Window appWin, out string msg)
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
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名称最少2个字，最多30个字！")).ToString();
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
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("账号名称最少2个字，最多30个字！")).ToString();
                        //关闭提醒框
                        btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                        btnTips.Click();

                        //点击取消按钮，关闭编辑窗口
                        Button btnCancleEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditUser"));
                        btnCancleEditUser.Click();

                        msg = "测试【编辑排牙师，账号名称少于2个字|多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑排牙师，账号名称少于2个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑排牙师，账号名称少于2个字|多于30个字】--未通过，缺少账号名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑排牙师，账号名称少于2个字|多于30个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑排牙师，不修改密码
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDocker_NoEditPwd(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDocker = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDocker").AndIndex(10));
                btnEditDocker.Click();

                //输入真实姓名
                TextBox txtRealName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtRealName"));
                txtRealName.Text = "1234";

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

                    msg = "测试【编辑排牙师，不修改密码】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑排牙师，不修改密码】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑排牙师，不修改密码】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑排牙师，修改密码为少于8位|多于30位
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDocker_PwdLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDocker = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDocker").AndIndex(10));
                btnEditDocker.Click();

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

                        msg = "测试【编辑排牙师，修改密码为少于8位|多于30位】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑排牙师，修改密码为少于8位|多于30位】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑排牙师，修改密码为少于8位|多于30位】--未通过，缺少密码长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑排牙师，修改密码为少于8位|多于30位】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑排牙师，邮箱地址格式不正确
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDocker_EmailError(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDocker = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDocker").AndIndex(10));
                btnEditDocker.Click();

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

                    msg = "测试【编辑排牙师，邮箱地址格式不正确】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑排牙师，邮箱地址格式不正确】--未通过，缺少邮箱地址验证提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑排牙师，邮箱地址格式不正确】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑排牙师，修改状态
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDocker_EditRole(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                Random num = new Random();
                int i = num.Next(10, 25);//产生10到25的随机数

                //点击编辑按钮
                Button btnEditDocker = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDocker").AndIndex(i));
                btnEditDocker.Click();

                //修改状态
                ComboBox cbStauts = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbStauts"));
                cbStauts.Select(1);

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

                    msg = "测试【编辑排牙师，修改角色】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑排牙师，修改角色】--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑排牙师，角色为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑排牙师，真实姓名为空|真实姓名多于30个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDocker_RealNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDocker = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDocker").AndIndex(10));
                btnEditDocker.Click();

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

                        msg = "测试【编辑排牙师，真实姓名为空|真实姓名多于30个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑排牙师，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【编辑排牙师，真实姓名为空|真实姓名多于30个字】--未通过，缺少真实姓名空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑排牙师，真实姓名为空|真实姓名多于30个字符】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑排牙师成功，同时关闭编辑用户窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDockerSucc(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDocker = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDocker").AndIndex(10));
                btnEditDocker.Click();

                //账号名称不为空
                TextBox txtUserName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                txtUserName.BulkText = Generate.GenerateChineseWords(3);

                //密码不少于8个字符
                TextBox pwdUserPwd = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditUserView")).Get<TextBox>(SearchCriteria.ByAutomationId("pwdUserPwd"));
                pwdUserPwd.Text = "12345678";

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
                        string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑排牙师")).ToString();

                        msg = "测试【编辑排牙师成功，同时关闭编辑排牙师窗口】--未通过，未关闭编辑排牙师窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【编辑排牙师成功，同时关闭编辑排牙师窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch
                {
                    msg = "测试【编辑排牙师成功，同时关闭编辑排牙师窗口】-未通过。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑排牙师成功，同时关闭编辑排牙师窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑排牙师，无修改操作，点击确定按钮
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDocker_NoEdit(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDocker = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDocker").AndIndex(10));
                btnEditDocker.Click();

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
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑排牙师")).ToString();

                    msg = "测试【编辑排牙师，无修改操作，点击确定按钮】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【编辑排牙师，无修改操作，点击确定按钮】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑排牙师，无修改操作，点击确定按钮】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑排牙师，点击取消按钮，关闭编辑排牙师窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditDocker_ClickCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditDocker = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditDocker").AndIndex(10));
                btnEditDocker.Click();

                //点击取消按钮
                Button btnCancleEditUser = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditUser"));
                btnCancleEditUser.Click();

                try
                {
                    //捕捉编辑排牙师窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑排牙师")).ToString();
                    msg = "测试【编辑排牙师，点击取消按钮，关闭编辑排牙师窗口】--未通过，未关闭编辑窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【编辑排牙师，点击取消按钮，关闭编辑排牙师窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑排牙师，点击取消按钮，关闭编辑排牙师窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region  删除用户

        /// <summary>
        /// 点击删除排牙师按钮，弹出提醒框，选择确定
        /// </summary>
        public static bool Del_DockerComfirm(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                Random num = new Random();
                int i = num.Next(10, 25);//产生10到25的随机数

                //点击删除按钮
                Button btnDelDocker = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnDelDocker").AndIndex(i));
                btnDelDocker.Click();

                try
                {
                    //捕捉提醒信息
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该排牙师？")).ToString();

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

                        msg = "测试【点击删除排牙师按钮，弹出提醒框，选择确定】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【点击删除排牙师按钮，弹出提醒框，选择确定】--未通过，缺少删除成功提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                }
                catch
                {
                    msg = "测试【点击删除排牙师按钮，弹出提醒框，选择确定】--未通过，未询问是否删除排牙师。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【点击删除排牙师按钮，弹出提醒框，选择确定】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 点击删除排牙师按钮，弹出提醒框，选择取消
        /// </summary>
        public static bool Del_DockerCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                Random num = new Random();
                int i = num.Next(10, 25);//产生10到25的随机数

                //点击删除按钮
                Button btnDelDocker = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnDelDocker").AndIndex(i));
                btnDelDocker.Click();

                try
                {
                    //捕捉提醒信息
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该排牙师？")).ToString();

                    //选择取消
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    try
                    {
                        //捕捉提醒信息，此处能捕捉到的话，测试不通过
                        error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该排牙师？")).ToString();

                        msg = "测试【点击删除排牙师按钮，弹出提醒框，选择取消】--未通过，没有关闭询问框。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return false;
                    }
                    catch
                    {
                        msg = "测试【点击删除排牙师按钮，弹出提醒框，选择取消】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch
                {
                    msg = "测试【点击删除排牙师按钮，弹出提醒框，选择取消】--未通过，未询问是否删除用户。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【点击删除排牙师按钮，弹出提醒框，选择取消】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

    }
}
