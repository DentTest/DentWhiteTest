using DentWhiteTest.Common;
using DentWhiteTest.Contacts;
using DentWhiteTest.TestCase;
using TestStack.White.UIItems.WindowItems;
using WhiteFrameDemo.TestCase;

namespace WhiteFrameDemo.Module
{
    public class UserModule
    {
        public static void UserAllTest()
        {
            Global.LstInfo.Add("--- 用户管理模块 ---");

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

            #region 用户列表

            //点击用户管理菜单，加载所有用户
            res_Launch = UserTest.Load_UserList(Global.win_Dent, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //输入用户名称，点击查询按钮，加载该用户
            res_Launch = UserTest.Search_UserName(Global.win_Dent, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //用户名称为空，点击查询按钮，加载所有用户
            res_Launch = UserTest.Search_UserNameNull(Global.win_Dent, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            #endregion


            //关闭客户端
            Global.win_Dent.Close();
        }
    }
}
