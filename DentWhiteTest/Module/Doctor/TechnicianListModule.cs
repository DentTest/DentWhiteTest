using DentWhiteTest.Common;
using DentWhiteTest.Contacts;
using DentWhiteTest.TestCase;
using DentWhiteTest.TestCase.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;

namespace DentWhiteTest.Module.Doctor
{
    public class TechnicianListModule
    {
        public static void TechnicianAllTest()
        {
            Global.LstInfo.Add("--- 订单管理模块 ---");

            //启动一个客户端
            bool res_Launch = WinHelp.Launch(out Window appWin, out string msg, Const.DoctorPath, Const.DoctorClientName, Const.DoctorId);
            Global.LstInfo.Add(msg);
            if (res_Launch)
            {
                Global.Win_Dentlab = appWin;

                //启动成功，登录
                var _login = LoginDoctorTest.LoginTechnician_Success(Global.Win_Dentlab, out string msg_login);
                Global.LstInfo.Add(msg_login);
                //如果登录失败，返回
                if (!_login) return;
            }
            else
            {
                return;
            }
            #region 订单查询

            //点击订单列表
            res_Launch = TechnicianTest.Load_OrderList(Global.Win_Dentlab, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //输入订单ID进行查询
            res_Launch = TechnicianTest.Search_OrderID(Global.Win_Dentlab, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //不输入内容点击查询
            res_Launch = TechnicianTest.Search_OrderIDNull(Global.Win_Dentlab, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            //根据状态进行查询
            res_Launch = TechnicianTest.Search_Statusl(Global.Win_Dentlab, out string msg4);
            Global.LstInfo.Add(msg4);
            if (!res_Launch) return;

            //输入医生名称查询
            res_Launch = TechnicianTest.Search_DoctorName(Global.Win_Dentlab, out string msg5);
            if (!res_Launch) return;

            //输入生产批号查询
            res_Launch = TechnicianTest.Search_UniqueNumber(Global.Win_Dentlab, out string msg6);
            Global.LstInfo.Add(msg6);
            if (!res_Launch) return;
            #endregion

            //关闭客户端
            Global.Win_Dentlab.Close();
        }
    }
}
