using DentWhiteTest.Contacts;
using TestStack.White.UIItems.WindowItems;
using DentWhiteTest.Common;
using DentWhiteTest.TestCase.Doctor;
using DentWhiteTest.TestCase.DoctorClient;

namespace DentWhiteTest.Module.Doctor
{
    /// <summary>
    /// 新增订单模块
    /// </summary>
    public class AddOrderModule
    {
        /// <summary>
        /// 医生新增订单测试
        /// </summary>
        public static void Doctor_AddOrderTest()
        {
            Global.LstInfo.Add("--- 登录模块 ---");

            #region 登陆医生

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


            //点击新增订单
            res_Launch = AddOrderTest.AddOrder_Succ(Global.Win_Dentlab, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //关闭客户端
            Global.Win_Dentlab.Close();
            #endregion
        }

        /// <summary>
        /// 医生管理员新增订单测试
        /// </summary>
        public static void DoctorAdmin_AddOrderTest()
        {
            Global.LstInfo.Add("--- 登录模块 ---");

            #region 登陆医生

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
            res_Launch = LoginDoctorTest.LoginSuperDoctor_Success(Global.Win_Dentlab, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;


            //点击新增订单
            res_Launch = AddOrderTest.AddOrder_Succ(Global.Win_Dentlab, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //关闭客户端
            Global.Win_Dentlab.Close();
            #endregion
        }

        /// <summary>
        /// 技工厂管理员新增订单测试
        /// </summary>
        public static void Factory_AddOrderTest()
        {
            Global.LstInfo.Add("--- 登录模块 ---");

            #region 登陆医生

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
            res_Launch = LoginDoctorTest.LoginFactory_Success(Global.Win_Dentlab, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;


            //点击新增订单
            res_Launch = AddOrderTest.AddOrder_Succ(Global.Win_Dentlab, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //关闭客户端
            Global.Win_Dentlab.Close();
            #endregion
        }
    }
}