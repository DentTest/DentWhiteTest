using DentWhiteTest.Contacts;
using WhiteFrameDemo.TestCase;
using TestStack.White.UIItems.WindowItems;
using DentWhiteTest.Common;

namespace WhiteFrameDemo.Module
{
    public class LoginModule
    {
        public static void LoginAllTest()
        {
            Global.LstInfo.Add("--- 登录模块 ---");

            #region 登陆成功

            //启动一个客户端
            bool res_Launch = WinHelp.Launch(out Window appWin, out string msg, Const.DockerPath, Const.DockerName, Const.DockerId);
            Global.LstInfo.Add(msg);
            if (res_Launch)
            {
                Global.win_Dent = appWin;
            }
            else
            {
                return;
            }

            //测试登录窗口,登录成功
            res_Launch = LoginTest.LoginDocker_Success(Global.win_Dent, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //关闭客户端
            Global.win_Dent.Close();

            #endregion

            #region 登陆账号密码为空

            //启动一个客户端
            res_Launch = WinHelp.Launch(out Window appWin1, out string msg2, Const.DockerPath, Const.DockerName, Const.DockerId);
            Global.LstInfo.Add(msg2);
            if (res_Launch)
            {
                Global.win_Dent = appWin1;
            }
            else
            {
                return;
            }

             //测试登录窗口,账号密码为空
            res_Launch = LoginTest.LoginDocker_UserNull_PwdNull(Global.win_Dent, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            //关闭客户端
            Global.win_Dent.Close();

            #endregion

            #region 登陆账号为空

            //启动一个客户端
            res_Launch = WinHelp.Launch(out Window appWin2, out string msg4, Const.DockerPath, Const.DockerName, Const.DockerId);
            Global.LstInfo.Add(msg4);
            if (res_Launch)
            {
                Global.win_Dent = appWin2;
            }
            else
            {
                return;
            }

            //测试登录窗口,账号为空
            res_Launch = LoginTest.LoginDocker_UserNull(Global.win_Dent, out string msg5);
            Global.LstInfo.Add(msg5);
            if (!res_Launch) return;

            //关闭客户端
            Global.win_Dent.Close();

            #endregion

            #region 登陆密码为空

            //启动一个客户端
            res_Launch = WinHelp.Launch(out Window appWin3, out string msg6, Const.DockerPath, Const.DockerName, Const.DockerId);
            Global.LstInfo.Add(msg6);
            if (res_Launch)
            {
                Global.win_Dent = appWin3;
            }
            else
            {
                return;
            }

            //测试登录窗口,密码为空
            res_Launch = LoginTest.LoginDocker_PwdNull(Global.win_Dent, out string msg7);
            Global.LstInfo.Add(msg7);
            if (!res_Launch) return;

            //关闭客户端
            Global.win_Dent.Close();

            #endregion
        }
    }
}
