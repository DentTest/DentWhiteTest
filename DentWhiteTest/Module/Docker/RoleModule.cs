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
    public class RoleModule
    {
        public static void RoleAllTest()
        {
            Global.LstInfo.Add("--- 角色管理模块 ---");

            //启动一个客户端
            bool res_Launch = WinHelp.Launch(out Window appWin, out string msg, Const.DockerPath, Const.DockerName, Const.DockerId);
            Global.LstInfo.Add(msg);
            if (res_Launch)
            {
                Global.win_Dent = appWin;

                //启动成功，登录
                var _login = LoginTest.LoginDocker_Success(Global.win_Dent,out string msg_login);
                Global.LstInfo.Add(msg_login);
                //如果登录失败，返回
                if (!_login) return;
            }
            else
            {
                return;
            }
                
            #region 角色列表

            //点击角色管理菜单，加载所有角色
            res_Launch = RoleTest.Load_RoleList(Global.win_Dent, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //输入角色名称，点击查询按钮，加载该角色
            res_Launch = RoleTest.Search_RoleName(Global.win_Dent, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //角色名称为空，点击查询按钮，加载所有角色
            res_Launch = RoleTest.Search_RoleNameNull(Global.win_Dent, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            #endregion


            //关闭客户端
            Global.win_Dent.Close();
        }
    }
}
