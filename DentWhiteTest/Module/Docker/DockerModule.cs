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
    public class DockerModule
    {
        public static void DockerAllTest()
        {
            Global.LstInfo.Add("--- 排牙师管理模块 ---");

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

            #region 查询排牙师列表

            //点击排牙师管理菜单，加载所有排牙师
            res_Launch = DockerTest.Load_DockerList(Global.Win_Docker, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //输入排牙师名称，点击查询按钮，加载该排牙师
            res_Launch = DockerTest.Search_DockerName(Global.Win_Docker, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //排牙师名称为空，点击查询按钮，加载所有排牙师
            res_Launch = DockerTest.Search_DockerNameNull(Global.Win_Docker, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            //输入排牙师姓名，点击查询按钮，加载该排牙师
            res_Launch = DockerTest.Search_DockerUserName(Global.Win_Docker, out string msg4);
            Global.LstInfo.Add(msg4);
            if (!res_Launch) return;

            //选择在线查询排牙师，点击查询按钮，加载所有在线排牙师
            res_Launch = DockerTest.Search_DockerOnline(Global.Win_Docker, out string msg5);
            Global.LstInfo.Add(msg5);
            if (!res_Launch) return;

            //选择不在线查询排牙师，点击查询按钮，加载所有不在线排牙师
            res_Launch = DockerTest.Search_DockerOnline2(Global.Win_Docker, out string msg6);
            Global.LstInfo.Add(msg6);
            if (!res_Launch) return;

            //输入排牙师名称和姓名，选择不在线查询排牙师，点击查询按钮，加载所有不在线排牙师
            res_Launch = DockerTest.Search_DockerUser_Name(Global.Win_Docker, out string msg19);
            Global.LstInfo.Add(msg19);
            if (!res_Launch) return;
            #endregion

            #region 编辑排牙师
            //编辑排牙师，账号名称为空
            res_Launch = DockerTest.EditDocker_UserNameNull(Global.Win_Docker, out string msg7);
            Global.LstInfo.Add(msg7);
            if (!res_Launch) return;

            //编辑排牙师，账号名称少于2个字符|多于30个字符
            res_Launch = DockerTest.EditDocker_UserNameLength(Global.Win_Docker, out string msg8);
            Global.LstInfo.Add(msg8);
            if (!res_Launch) return;

            //编辑排牙师，不修改密码
            res_Launch = DockerTest.EditDocker_NoEditPwd(Global.Win_Docker, out string msg9);
            Global.LstInfo.Add(msg9);
            if (!res_Launch) return;

            //编辑排牙师，修改密码为少于8位|多于30位
            res_Launch = DockerTest.EditDocker_PwdLength(Global.Win_Docker, out string msg10);
            Global.LstInfo.Add(msg10);
            if (!res_Launch) return;

            //编辑排牙师，邮箱地址格式不正确
            res_Launch = DockerTest.EditDocker_EmailError(Global.Win_Docker, out string msg11);
            Global.LstInfo.Add(msg11);
            if (!res_Launch) return;

            //编辑排牙师，修改角色为空
            res_Launch = DockerTest.EditDocker_EditRole(Global.Win_Docker, out string msg12);
            Global.LstInfo.Add(msg12);
            if (!res_Launch) return;

            //编辑排牙师，真实姓名为空|真实姓名多于30个字符
            res_Launch = DockerTest.EditDocker_RealNameLength(Global.Win_Docker, out string msg13);
            Global.LstInfo.Add(msg13);
            if (!res_Launch) return;

            //编辑排牙师成功，同时关闭编辑用户窗口
            res_Launch = DockerTest.EditDockerSucc(Global.Win_Docker, out string msg14);
            Global.LstInfo.Add(msg14);
            if (!res_Launch) return;

            //编辑排牙师，无修改操作，点击确定按钮
            res_Launch = DockerTest.EditDocker_NoEdit(Global.Win_Docker, out string msg15);
            Global.LstInfo.Add(msg15);
            if (!res_Launch) return;

            //编辑排牙师，点击取消按钮，关闭编辑用户窗口
            res_Launch = DockerTest.EditDocker_ClickCancle(Global.Win_Docker, out string msg16);
            Global.LstInfo.Add(msg16);
            if (!res_Launch) return;
            #endregion

            #region 删除用户

            //点击删除用户按钮，弹出提醒框，选择确定
            res_Launch = DockerTest.Del_DockerComfirm(Global.Win_Docker, out string msg17);
            Global.LstInfo.Add(msg17);
            if (!res_Launch) return;

            //点击删除用户按钮，弹出提醒框，选择取消
            res_Launch = DockerTest.Del_DockerCancle(Global.Win_Docker, out string msg18);
            Global.LstInfo.Add(msg18);
            if (!res_Launch) return;

            #endregion

            //关闭客户端
            Global.Win_Docker.Close();
        }
    }
}
