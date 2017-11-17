using DentWhiteTest.Contacts;
using TestStack.White.UIItems.WindowItems;
using DentWhiteTest.Common;
using DentWhiteTest.TestCase.Doctor;

namespace DentWhiteTest.Module.Doctor
{
    public class DoctorLoginModule
    {
        public static void LoginAllTest()
        {
            Global.LstInfo.Add("--- 登录模块 ---");

            #region 登陆成功

            //启动一个客户端
            bool res_Launch = WinHelp.Launch(out Window appWin, out string msg, Const.DoctorPath, Const.DoctorClientName, Const.DoctorId);
            Global.LstInfo.Add(msg);
            if (res_Launch)
            {
                Global.Win_Dentlab = appWin;
            }
            else
            {
                return;
            }

            //测试登录窗口,登录成功
            res_Launch = LoginDoctorTest.LoginDoctor_Success(Global.Win_Dentlab, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //关闭客户端
            Global.Win_Dentlab.Close();

            #endregion

            #region 登陆账号密码为空

            //启动一个客户端
            res_Launch = WinHelp.Launch(out Window appWin1, out string msg2, Const.DoctorPath, Const.DentName, Const.DoctorId);
            Global.LstInfo.Add(msg2);
            if (res_Launch)
            {
                Global.Win_Dentlab = appWin1;
            }
            else
            {
                return;
            }

            //测试登录窗口,账号密码为空
            res_Launch = LoginDoctorTest.LoginDoctor_UserNull_PwdNull(Global.Win_Dentlab, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            //关闭客户端
            Global.Win_Dentlab.Close();

            #endregion

            #region 登陆账号为空

            //启动一个客户端
            res_Launch = WinHelp.Launch(out Window appWin2, out string msg4, Const.DoctorPath, Const.DentName, Const.DoctorId);
            Global.LstInfo.Add(msg4);
            if (res_Launch)
            {
                Global.Win_Dentlab = appWin2;
            }
            else
            {
                return;
            }

            //测试登录窗口,账号为空
            res_Launch = LoginDoctorTest.LoginDoctor_UserNull(Global.Win_Dentlab, out string msg5);
            Global.LstInfo.Add(msg5);
            if (!res_Launch) return;

            //关闭客户端
            Global.Win_Dentlab.Close();

            #endregion

            #region 登陆密码为空

            //启动一个客户端
            res_Launch = WinHelp.Launch(out Window appWin3, out string msg6, Const.DoctorPath, Const.DentName, Const.DoctorId);
            Global.LstInfo.Add(msg6);
            if (res_Launch)
            {
                Global.Win_Dentlab = appWin3;
            }
            else
            {
                return;
            }

            //测试登录窗口,密码为空
            res_Launch = LoginDoctorTest.LoginDoctor_PwdNull(Global.Win_Dentlab, out string msg7);
            Global.LstInfo.Add(msg7);
            if (!res_Launch) return;

            //关闭客户端
            Global.Win_Dentlab.Close();

            #endregion

            #region 登陆技工厂成功

            //启动一个客户端
            res_Launch = WinHelp.Launch(out Window appWin4, out string msg8, Const.DoctorPath, Const.DoctorClientName, Const.DoctorId);
            Global.LstInfo.Add(msg8);
            if (res_Launch)
            {
                Global.Win_Dentlab = appWin4;
            }
            else
            {
                return;
            }

            //测试登录窗口,登录成功
            res_Launch = LoginDoctorTest.LoginFactory_Success(Global.Win_Dentlab, out string msg9);
            Global.LstInfo.Add(msg9);
            if (!res_Launch) return;

            //关闭客户端
            Global.Win_Dentlab.Close();

            #endregion
        }
    }
}
