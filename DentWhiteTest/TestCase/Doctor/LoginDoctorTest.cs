using System;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using System.Threading;
using TestStack.White.UIItems.WindowItems;

namespace DentWhiteTest.TestCase.Doctor
{
    public class LoginDoctorTest
    {
        /// <summary>
        /// 测试登录窗口,账号密码为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginDoctor_UserNull_PwdNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //账号和密码为空
                TextBox tbUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                TextBox tdPwd = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("pbPassword"));
                tbUser.Text = "";
                tdPwd.Text = "";
                var endTime = DateTime.Now;

                //点击登录按钮 
                Button loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));
                loginbt.Click();

                loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));

                //抓不到按钮，登录成功
                if (loginbt == null)
                {
                    msg = "测试【登录窗口,账号密码为空】--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                else
                {
                    msg = "测试【登录窗口,账号密码为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }


            }
            catch (Exception e)
            {
                msg = "测试【登录窗口,账号密码为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 测试登录窗口,账号为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginDoctor_UserNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //账号为空
                TextBox tbUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                TextBox tdPwd = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("pbPassword"));
                tbUser.Text = "";
                tdPwd.Text = "123456";
                var endTime = DateTime.Now;

                //点击登录按钮 
                Button loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));
                loginbt.Click();

                loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));

                //抓不到按钮，登录成功
                if (loginbt == null)
                {
                    msg = "测试【登录窗口,账号为空】--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                else
                {
                    msg = "测试【登录窗口,账号为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }


            }
            catch (Exception e)
            {
                msg = "测试【登录窗口,账号为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 测试登录窗口,密码为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginDoctor_PwdNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //账号：dent_bicheno
                //密码：123456789
                TextBox tbUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                TextBox tdPwd = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("pbPassword"));
                //Language.Set("en");
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SHIFT);
                Thread.Sleep(1000);
                tbUser.Text = "bwl_doctor";
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);
                tdPwd.Text = "";
                var endTime = DateTime.Now;

                //点击登录按钮 
                Button loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));
                loginbt.Click();

                loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));

                //抓不到按钮，登录成功
                if (loginbt == null)
                {
                    msg = "测试【登录窗口,密码为空】--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                else
                {
                    msg = "测试【登录窗口,密码为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【登录窗口,密码为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 测试登录窗口,成功登陆(登录医生)
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginDoctor_Success(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //账号：dent_bicheno
                //密码：123456789
                TextBox tbUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                TextBox tdPwd = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("pbPassword"));
                //Language.Set("en");
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SHIFT);
                Thread.Sleep(1000);
                //tbUser.Text = "test_admin";
                tbUser.Text = "bwl_doctor";
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);
                //tdPwd.Text = "hgzz@2017";
                tdPwd.Text = "123456789";
                var endTime = DateTime.Now;

                //点击登录按钮 
                Button loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));
                loginbt.Click();

                try
                {
                    //点击订单列表菜单
                    Button tlOrderListModule = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlOrderListModule"));
                    tlOrderListModule.Click();

                    //点击查询按钮，如果能捕捉到，则测试通过
                    Button btnSearch = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnOrderListSearch"));
                    btnSearch.Click();

                    //点击返回主页按钮
                    Button btnCloseView = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCloseView"));
                    btnCloseView.Click();

                    try
                    {
                        //捕捉医院管理菜单，如果能捕捉到，则测试通过
                        Button tlHospitalManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlHospitalManagement"));
                        tlHospitalManagement.Click();
                        msg = "测试【登录医生账号成功】--未通过，权限未分配好，用时：" + (endTime - startTime).TotalSeconds;
                        return false;

                    }
                    catch
                    {
                        msg = "测试【登录医生账号成功】--通过，用时：" + (endTime - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch (Exception e)
                {
                    msg = "测试【登录窗口,登陆成功】--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【登录窗口,登陆成功】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 测试登录窗口,成功登陆（登录技工厂管理员）
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginFactory_Success(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //账号：bcy_dentlab
                //密码：123456789
                TextBox tbUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                TextBox tdPwd = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("pbPassword"));
                //Language.Set("en");
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SHIFT);
                Thread.Sleep(1000);
                //tbUser.Text = "test_admin";
                tbUser.Text = "bwl_dentlab";
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);
                //tdPwd.Text = "hgzz@2017";
                tdPwd.Text = "123456789";
                var endTime = DateTime.Now;

                //点击登录按钮 
                Button loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));
                loginbt.Click();

                try
                {
                    //捕捉医院管理菜单
                    Button tlHospitalManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlHospitalManagement"));
                    tlHospitalManagement.Click();

                    //点击查询按钮，如果能点击，则测试通过（测试登录框是否已关闭）
                    Button btnSearch = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearch"));
                    btnSearch.Click();

                    //点击返回主页按钮
                    Button btnCloseView = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCloseView"));
                    btnCloseView.Click();

                    msg = "测试【登录技工厂账号成功，能铺捉到医院】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【登录技工厂账号成功】--未通过。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【登录技工厂窗口,登陆成功】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 测试登录窗口,成功登陆（登录技师）
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginTechnician_Success(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                TextBox tbUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                TextBox tdPwd = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("pbPassword"));

                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SHIFT);
                Thread.Sleep(1000);
                tbUser.Text = "bwl_technician";
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);
                tdPwd.Text = "123456789";

                var endTime = DateTime.Now;

                //点击登录按钮 
                Button loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));
                loginbt.Click();

                try
                {
                    //捕捉医院管理菜单
                    Button tlHospitalManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlHospitalManagement"));
                    tlHospitalManagement.Click();

                    ////点击查询按钮，如果能点击，则测试通过（测试登录框是否已关闭）
                    //Button btnSearch = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearch"));
                    //btnSearch.Click();

                    ////点击返回主页按钮
                    //Button btnCloseView = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCloseView"));
                    //btnCloseView.Click();

                    msg = "测试【登录排牙师账号成功，能铺捉到医院】--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【登录排牙师账号成功】--通过。用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【登录排牙师窗口,登陆成功】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 测试登录窗口,成功登陆（登录医生管理员）
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginSuperDoctor_Success(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //账号：bcy_dentlab
                //密码：123456789
                TextBox tbUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtUserName"));
                TextBox tdPwd = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("pbPassword"));
                //Language.Set("en");
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SHIFT);
                Thread.Sleep(1000);
                //tbUser.Text = "test_admin";
                tbUser.Text = "bwlsuper_doctor";
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);
                //tdPwd.Text = "hgzz@2017";
                tdPwd.Text = "123456789";
                var endTime = DateTime.Now;

                //点击登录按钮 
                Button loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));
                loginbt.Click();

                try
                {
                    //捕捉医院管理菜单
                    Button tlDoctorManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlDoctorManagement"));
                    tlDoctorManagement.Click();

                    //点击查询按钮，如果能点击，则测试通过（测试登录框是否已关闭）
                    Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                    btnSearchOrderList.Click();

                    //点击返回主页按钮
                    Button btnCloseView = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCloseView"));
                    btnCloseView.Click();

                    msg = "测试【登录医生管理员账号成功，能铺捉到医院】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
                catch
                {
                    msg = "测试【登录医生管理员账号成功，找不到医院管理按钮】--未通过。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【登录医生管理员窗口,登陆成功】--失败，原因：" + e.ToString();
                return false;
            }
        }
    }
}

