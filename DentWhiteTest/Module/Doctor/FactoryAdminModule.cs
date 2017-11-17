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
using WhiteFrameDemo.TestCase;

namespace DentWhiteTest.Module.Denture
{
    public class FactoryAdminModule
    {
        public static void FactoryAdminAllTest()
        {
            Global.LstInfo.Add("--- 技师管理模块 ---");

            //启动一个客户端
            bool res_Launch = WinHelp.Launch(out Window appWin, out string msg, Const.DoctorPath, Const.DoctorClientName, Const.DoctorId);
            Global.LstInfo.Add(msg);
            if (res_Launch)
            {
                Global.Win_Dentlab = appWin;

                //启动成功，登录
                var _login = LoginDoctorTest.LoginFactory_Success(Global.Win_Dentlab, out string msg_login);
                Global.LstInfo.Add(msg_login);
                //如果登录失败，返回
                if (!_login) return;
            }
            else
            {
                return;
            }

            #region 技师列表

            //点击技师管理菜单，加载所有技师
            res_Launch = FactoryAdminTest.Load_TechnicianList(Global.Win_Dentlab, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //输入账号名，点击查询按钮，加载该技师
            res_Launch = FactoryAdminTest.Search_TechnicianName(Global.Win_Dentlab, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //输入技师姓名，点击查询按钮，加载该技师
            res_Launch = FactoryAdminTest.Search_TechnicianUserName(Global.Win_Dentlab, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            //选择是否在线，点击查询按钮，加载是否在线技师
            res_Launch = FactoryAdminTest.Search_TechnicianOnline2(Global.Win_Dentlab, out string msg28);
            Global.LstInfo.Add(msg28);
            if (!res_Launch) return;

            //选择是否在线，点击查询按钮，加载是否在线技师
            res_Launch = FactoryAdminTest.Search_TechnicianOnline(Global.Win_Dentlab, out string msg4);
            Global.LstInfo.Add(msg4);
            if (!res_Launch) return;

            //技师名称为空，点击查询按钮，加载所有技师
            res_Launch = FactoryAdminTest.Search_TechnicianNameNull(Global.Win_Dentlab, out string msg5);
            Global.LstInfo.Add(msg5);
            if (!res_Launch) return;

            #endregion

            #region 新增技师
            //新增技师，账号名为空
            res_Launch = FactoryAdminTest.AddTechnician_UserNameNull(Global.Win_Dentlab, out string msg6);
            Global.LstInfo.Add(msg6);
            if (!res_Launch) return;

            //新增技师，账号名称最少5个字 | 多于30个字
            res_Launch = FactoryAdminTest.AddTechnician_UserNameLength(Global.Win_Dentlab, out string msg7);
            Global.LstInfo.Add(msg7);
            if (!res_Launch) return;

            //新增技师，密码为空
            res_Launch = FactoryAdminTest.AddTechnician_PwdNull(Global.Win_Dentlab, out string msg8);
            Global.LstInfo.Add(msg8);
            if (!res_Launch) return;

            //新增技师，密码少于8位|多于30位
            res_Launch = FactoryAdminTest.AddTechnician_PwdLength(Global.Win_Dentlab, out string msg9);
            Global.LstInfo.Add(msg9);
            if (!res_Launch) return;

            // 新增技师，邮箱地址格式不正确
            res_Launch = FactoryAdminTest.AddTechnician_EmailError(Global.Win_Dentlab, out string msg10);
            Global.LstInfo.Add(msg10);
            if (!res_Launch) return;

            // 新增技师，真实姓名为空|真实姓名多于30个字
            res_Launch = FactoryAdminTest.AddTechnician_RealNameLength(Global.Win_Dentlab, out string msg13);
            Global.LstInfo.Add(msg13);
            if (!res_Launch) return;

            // 新增技师成功，同时关闭新增技师窗口
            res_Launch = FactoryAdminTest.AddTechnicianSucc(Global.Win_Dentlab, out string msg12);
            Global.LstInfo.Add(msg12);
            if (!res_Launch) return;

            // 新增技师，点击取消按钮，关闭新增技师窗口
            res_Launch = FactoryAdminTest.AddTechnician_ClickCancle(Global.Win_Dentlab, out string msg14);
            Global.LstInfo.Add(msg14);
            if (!res_Launch) return;
            #endregion

            #region 编辑技师
            //编辑技师，账号名为空
            res_Launch = FactoryAdminTest.EditTechnician_UserNameNull(Global.Win_Dentlab, out string msg15);
            Global.LstInfo.Add(msg15);
            if (!res_Launch) return;

            //编辑技师，账号名称最少5个字|多于30个字
            res_Launch = FactoryAdminTest.EditTechnician_UserNameLength(Global.Win_Dentlab, out string msg16);
            Global.LstInfo.Add(msg16);
            if (!res_Launch) return;

            //编辑技师，不修改密码
            res_Launch = FactoryAdminTest.EditTechnician_NoEditPwd(Global.Win_Dentlab, out string msg17);
            Global.LstInfo.Add(msg17);
            if (!res_Launch) return;

            //编辑技师，修改密码为少于8位|多于30位
            res_Launch = FactoryAdminTest.EditTechnician_PwdLength(Global.Win_Dentlab, out string msg18);
            Global.LstInfo.Add(msg18);
            if (!res_Launch) return;

            //编辑技师，邮箱地址格式不正确
            res_Launch = FactoryAdminTest.EditTechnician_EmailError(Global.Win_Dentlab, out string msg19);
            Global.LstInfo.Add(msg19);
            if (!res_Launch) return;

            //编辑技师，真实姓名为空|真实姓名多于30个字
            res_Launch = FactoryAdminTest.EditTechnician_RealNameLength(Global.Win_Dentlab, out string msg20);
            Global.LstInfo.Add(msg20);
            if (!res_Launch) return;

            //编辑技师，修改状态
            res_Launch = FactoryAdminTest.EditTechnician_EditRole(Global.Win_Dentlab, out string msg21);
            Global.LstInfo.Add(msg21);
            if (!res_Launch) return;

            //编辑技师成功，同时关闭编辑技师窗口
            res_Launch = FactoryAdminTest.EditTechnicianSucc(Global.Win_Dentlab, out string msg23);
            Global.LstInfo.Add(msg23);
            if (!res_Launch) return;

            //编辑技师，无修改操作，点击确定按钮
            res_Launch = FactoryAdminTest.EditTechnician_NoEdit(Global.Win_Dentlab, out string msg24);
            Global.LstInfo.Add(msg24);
            if (!res_Launch) return;

            //编辑技师，点击取消按钮，关闭编辑技师窗口
            res_Launch = FactoryAdminTest.EditTechnician_ClickCancle(Global.Win_Dentlab, out string msg25);
            Global.LstInfo.Add(msg25);
            if (!res_Launch) return;

            #endregion

            #region 删除技师
            //点击删除技师按钮，弹出提醒框，选择确定
            res_Launch = FactoryAdminTest.Del_TechnicianComfirm(Global.Win_Dentlab, out string msg26);
            Global.LstInfo.Add(msg26);
            if (!res_Launch) return;

            //点击删除技师按钮，弹出提醒框，选择取消
            res_Launch = FactoryAdminTest.Del_TechnicianCancle(Global.Win_Dentlab, out string msg27);
            Global.LstInfo.Add(msg27);
            if (!res_Launch) return;
            #endregion


            //关闭客户端
            Global.Win_Dentlab.Close();
        }
    }
}
