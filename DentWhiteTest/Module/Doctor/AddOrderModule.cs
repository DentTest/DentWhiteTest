using DentWhiteTest.Contacts;
using TestStack.White.UIItems.WindowItems;
using DentWhiteTest.Common;
using DentWhiteTest.TestCase.Doctor;
using DentWhiteTest.TestCase.DoctorClient;

namespace DentWhiteTest.Module.Doctor
{
    public class AddOrderModule
    {
        public static void AddOrderAllTest()
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