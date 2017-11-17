using DentWhiteTest.Common;
using DentWhiteTest.Contacts;
using DentWhiteTest.TestCase;
using DentWhiteTest.TestCase.Docker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;
using WhiteFrameDemo.TestCase;

namespace DentWhiteTest.Module.Denture
{
    public class RoleModule
    {
        public static void RoleAllTest()
        {
            Global.LstInfo.Add("--- 角色管理模块 ---");

            //启动一个客户端
            bool res_Launch = WinHelp.Launch(out Window appWin, out string msg, Const.DenturePath, Const.DentName, Const.DentureId);
            Global.LstInfo.Add(msg);
            if (res_Launch)
            {
                Global.Win_Denture = appWin;

                //启动成功，登录
                var _login = LoginDentureTest.LoginDenture_Success(Global.Win_Denture,out string msg_login);
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
            res_Launch = RoleTest.Load_RoleList(Global.Win_Denture, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //输入角色名称，点击查询按钮，加载该角色
            res_Launch = RoleTest.Search_RoleName(Global.Win_Denture, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //角色名称为空，点击查询按钮，加载所有角色
            res_Launch = RoleTest.Search_RoleNameNull(Global.Win_Denture, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            #endregion

            #region 新增角色

            //新增角色，角色名称为空
            res_Launch = RoleTest.AddRole_RoleNameBull(Global.Win_Denture, out string msg4);
            Global.LstInfo.Add(msg4);
            if (!res_Launch) return;

            //新增角色，角色英文别名为空
            res_Launch = RoleTest.AddRole_EnRoleNameBull(Global.Win_Denture, out string msg5);
            Global.LstInfo.Add(msg5);
            if (!res_Launch) return;

            //新增角色成功，同时关闭新增角色窗口
            res_Launch = RoleTest.AddRoleSucc(Global.Win_Denture, out string msg6);
            Global.LstInfo.Add(msg6);
            if (!res_Launch) return;

            //新增角色，点击取消按钮，关闭新增角色窗口
            res_Launch = RoleTest.AddRole_ClickCancle(Global.Win_Denture, out string msg7);
            Global.LstInfo.Add(msg7);
            if (!res_Launch) return;

            #endregion

            #region 编辑角色

            //编辑角色，角色名称为空
            res_Launch = RoleTest.EditRole_RoleNameBull(Global.Win_Denture, out string msg8);
            Global.LstInfo.Add(msg8);
            if (!res_Launch) return;

            //编辑角色，角色英文别名为空
            res_Launch = RoleTest.EditRole_EnRoleNameBull(Global.Win_Denture, out string msg9);
            Global.LstInfo.Add(msg9);
            if (!res_Launch) return;

            //编辑角色，无修改操作，点击确定按钮
            res_Launch = RoleTest.EditRole_NoEdit(Global.Win_Denture, out string msg10);
            Global.LstInfo.Add(msg10);
            if (!res_Launch) return;

            //编辑角色，修改角色名称和角色英文别名
            res_Launch = RoleTest.EditRole(Global.Win_Denture, out string msg11);
            Global.LstInfo.Add(msg11);
            if (!res_Launch) return;

            //编辑角色，点击取消按钮，关闭编辑角色窗口
            res_Launch = RoleTest.EditRole_ClickCancle(Global.Win_Denture, out string msg12);
            Global.LstInfo.Add(msg12);
            if (!res_Launch) return;

            #endregion

            //关闭客户端
            Global.Win_Denture.Close();
        }
    }
}
