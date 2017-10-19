using System;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using System.Threading;
using TestStack.White.UIItems.WindowItems;

namespace WhiteFrameDemo.TestCase
{
    public class LoginTest
    {
        /// <summary>
        /// 测试登录窗口,账号密码为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginDocker_UserNull_PwdNull(Window appWin, out string msg)
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
        public static bool LoginDocker_UserNull(Window appWin, out string msg)
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
        /// 测试登录窗口,成功登陆
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginDocker_Success(Window appWin, out string msg)
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
                tbUser.Text = "bwl";
                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);
                //tdPwd.Text = "hgzz@2017";
                tdPwd.Text = "12345678";
                var endTime = DateTime.Now;

                //点击登录按钮 
                Button loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));
                loginbt.Click();

                loginbt = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnConfirmLogin"));

                //抓不到按钮，登录成功
                if (loginbt == null)
                {
                    msg = "测试【登录窗口,登陆成功】--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                else
                {
                    msg = "测试【登录窗口,登陆成功】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【登录窗口,登陆成功】--失败，原因：" + e.ToString();
                return false;
            }
        }


        /// <summary>
        /// 测试登录窗口,密码为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool LoginDocker_PwdNull(Window appWin, out string msg)
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
                tbUser.Text = "dent_bicheno";
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
    }
}
