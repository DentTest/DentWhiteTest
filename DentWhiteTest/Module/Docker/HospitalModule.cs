using DentWhiteTest.Common;
using DentWhiteTest.Contacts;
using DentWhiteTest.TestCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;
using WhiteFrameDemo.TestCase;

namespace DentWhiteTest.Module
{
    public class HospitalModule
    {
        public static void HospitalAllTest()
        {
            Global.LstInfo.Add("--- 医院管理模块 ---");

            //启动一个客户端
            bool res_Launch = WinHelp.Launch(out Window appWin, out string msg, Const.DockerPath, Const.DockerName, Const.DockerId);
            Global.LstInfo.Add(msg);
            if (res_Launch)
            {
                Global.win_Dent = appWin;

                //启动成功，登录
                var _login = LoginTest.LoginDocker_Success(Global.win_Dent, out string msg_login);
                Global.LstInfo.Add(msg_login);
                //如果登录失败，返回
                if (!_login) return;
            }
            else
            {
                return;
            }

            #region 医院列表

            //点击医院管理菜单，加载所有医院
            res_Launch = HospitalTest.Load_HospitalList(Global.win_Dent, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //输入医院名称，点击查询按钮，加载该医院
            res_Launch = HospitalTest.Search_HospitalName(Global.win_Dent, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //医院名称为空，点击查询按钮，加载所有医院
            res_Launch = HospitalTest.Search_HospitalNameNull(Global.win_Dent, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            #endregion


            //关闭客户端
            Global.win_Dent.Close();
        }
    }
}
