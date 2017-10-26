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
    public class DoctorModule
    {
        public static void DoctorAllTest()
        {
            Global.LstInfo.Add("--- 医生管理模块 ---");

            //启动一个客户端
            bool res_Launch = WinHelp.Launch(out Window appWin, out string msg, Const.DockerPath, Const.DentName, Const.DockerId);
            Global.LstInfo.Add(msg);
            if (res_Launch)
            {
                Global.Win_Docker = appWin;

                //启动成功，登录
                var _login = LoginTest.LoginDocker_Success(Global.Win_Docker, out string msg_login);
                Global.LstInfo.Add(msg_login);
                //如果登录失败，返回
                if (!_login) return;
            }
            else
            {
                return;
            }

            #region 医生列表

            //点击医生管理菜单，加载所有医生
            res_Launch = DoctorTest.Load_DoctorList(Global.Win_Docker, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //输入医生名称，点击查询按钮，加载该医生
            res_Launch = DoctorTest.Search_DoctorName(Global.Win_Docker, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //医生名称为空，点击查询按钮，加载所有医生
            res_Launch = DoctorTest.Search_DoctorNameNull(Global.Win_Docker, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            #endregion


            //关闭客户端
            Global.Win_Docker.Close();
        }
    }
}
