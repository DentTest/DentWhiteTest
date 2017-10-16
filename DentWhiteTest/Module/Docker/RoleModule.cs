﻿using DentWhiteTest.Common;
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
                Global.Win_Docker = appWin;

                //启动成功，登录
                var _login = LoginTest.LoginDocker_Success(Global.Win_Docker,out string msg_login);
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
            res_Launch = RoleTest.Load_RoleList(Global.Win_Docker, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //输入角色名称，点击查询按钮，加载该角色
            res_Launch = RoleTest.Search_RoleName(Global.Win_Docker, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //角色名称为空，点击查询按钮，加载所有角色
            res_Launch = RoleTest.Search_RoleNameNull(Global.Win_Docker, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            #endregion

            #region 新增角色

            //新增角色，角色名称为空
            res_Launch = RoleTest.AddRole_RoleNameBull(Global.Win_Docker, out string msg4);
            Global.LstInfo.Add(msg4);
            if (!res_Launch) return;

            //新增角色，角色英文别名为空
            res_Launch = RoleTest.AddRole_EnRoleNameBull(Global.Win_Docker, out string msg5);
            Global.LstInfo.Add(msg5);
            if (!res_Launch) return;

            //新增角色成功，同时关闭新增角色窗口
            res_Launch = RoleTest.AddRoleSucc(Global.Win_Docker, out string msg6);
            Global.LstInfo.Add(msg6);
            if (!res_Launch) return;

            //新增角色，点击取消按钮，关闭新增角色窗口
            res_Launch = RoleTest.AddRole_ClickCancle(Global.Win_Docker, out string msg7);
            Global.LstInfo.Add(msg7);
            if (!res_Launch) return;

            #endregion

            #region 编辑角色

            #endregion


            //关闭客户端
            Global.Win_Docker.Close();
        }
    }
}