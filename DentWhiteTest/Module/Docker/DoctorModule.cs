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

            //输入账号名，点击查询按钮，加载该医生
            res_Launch = DoctorTest.Search_DoctoruserName(Global.Win_Docker, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //输入医生名称，点击查询按钮，加载该医生
            res_Launch = DoctorTest.Search_DoctorName(Global.Win_Docker, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            //选择是否在线，点击查询按钮，加载是否在线医生
            res_Launch = DoctorTest.Search_DoctorUnOnline(Global.Win_Docker, out string msg4);
            Global.LstInfo.Add(msg4);
            if (!res_Launch) return;

            //医生名称为空，点击查询按钮，加载所有医生
            res_Launch = DoctorTest.Search_DoctorNameNull(Global.Win_Docker, out string msg5);
            Global.LstInfo.Add(msg5);
            if (!res_Launch) return;

            #endregion

            #region 新增医生
            //新增医生，账号名为空
            res_Launch = DoctorTest.AddDoctor_DoctorNameNull(Global.Win_Docker, out string msg6);
            Global.LstInfo.Add(msg6);
            if (!res_Launch) return;

            //新增医生，账号名称少于2个字 | 多于30个字
            res_Launch = DoctorTest.AddDoctor_DoctorNameLength(Global.Win_Docker, out string msg7);
            Global.LstInfo.Add(msg7);
            if (!res_Launch) return;

            //新增医生，密码为空
            res_Launch = DoctorTest.AddDoctor_PwdBull(Global.Win_Docker, out string msg8);
            Global.LstInfo.Add(msg8);
            if (!res_Launch) return;

            //新增医生，密码少于8位|多于30位
            res_Launch = DoctorTest.AddDoctor_PwdLength(Global.Win_Docker, out string msg9);
            Global.LstInfo.Add(msg9);
            if (!res_Launch) return;

            // 新增医生，邮箱地址格式不正确
            res_Launch = DoctorTest.AddDoctor_RealNameLength(Global.Win_Docker, out string msg10);
            Global.LstInfo.Add(msg10);
            if (!res_Launch) return;

            // 新增用户，医院为空
            res_Launch = DoctorTest.AddDoctor_HospitalNull(Global.Win_Docker, out string msg11);
            Global.LstInfo.Add(msg11);
            if (!res_Launch) return;

            // 新增医生，邮箱地址格式不正确
            res_Launch = DoctorTest.AddDoctor_MarkerNull(Global.Win_Docker, out string msg12);
            Global.LstInfo.Add(msg12);
            if (!res_Launch) return;

            // 新增医生，邮箱地址格式不正确
            res_Launch = DoctorTest.AddDoctor_RealNameLength(Global.Win_Docker, out string msg13);
            Global.LstInfo.Add(msg13);

            // 新增医生，点击取消按钮，关闭新增医生窗口
            res_Launch = DoctorTest.AddDoctor_ClickCancle(Global.Win_Docker, out string msg14);
            Global.LstInfo.Add(msg14);
            if (!res_Launch) return;
            #endregion

            #region 编辑医生
            //编辑医生，账号名为空
            res_Launch = DoctorTest.EditDoctor_DoctorNameNull(Global.Win_Docker, out string msg15);
            Global.LstInfo.Add(msg15);
            if (!res_Launch) return;

            //编辑医生，账号名称少于2个字|多于30个字
            res_Launch = DoctorTest.EditDoctor_DoctorNameLength(Global.Win_Docker, out string msg16);
            Global.LstInfo.Add(msg16);
            if (!res_Launch) return;

            //编辑医生，不修改密码
            res_Launch = DoctorTest.EditDoctor_NoEditPwd(Global.Win_Docker, out string msg17);
            Global.LstInfo.Add(msg17);
            if (!res_Launch) return;

            //编辑医生，修改密码为少于8位|多于30位
            res_Launch = DoctorTest.EditDoctor_PwdLength(Global.Win_Docker, out string msg18);
            Global.LstInfo.Add(msg18);
            if (!res_Launch) return;

            //编辑医生，邮箱地址格式不正确
            res_Launch = DoctorTest.EditDoctor_EmailError(Global.Win_Docker, out string msg19);
            Global.LstInfo.Add(msg19);
            if (!res_Launch) return;

            //编辑医生，真实姓名为空|真实姓名多于30个字
            res_Launch = DoctorTest.EditDoctor_RealNameLength(Global.Win_Docker, out string msg20);
            Global.LstInfo.Add(msg20);
            if (!res_Launch) return;

            //编辑医生，修改所在医院
            res_Launch = DoctorTest.EditDoctor_EditHospital(Global.Win_Docker, out string msg21);
            Global.LstInfo.Add(msg21);
            if (!res_Launch) return;

            //编辑医生，修改市场负责人
            res_Launch = DoctorTest.EditDoctor_Marker(Global.Win_Docker, out string msg22);
            Global.LstInfo.Add(msg22);
            if (!res_Launch) return;

            //编辑医生成功，同时关闭编辑医生窗口
            res_Launch = DoctorTest.EditDoctorSucc(Global.Win_Docker, out string msg23);
            Global.LstInfo.Add(msg23);
            if (!res_Launch) return;

            //编辑医生，无修改操作，点击确定按钮
            res_Launch = DoctorTest.EditDoctor_NoEdit(Global.Win_Docker, out string msg24);
            Global.LstInfo.Add(msg24);
            if (!res_Launch) return;

            //编辑医生，点击取消按钮，关闭编辑医生窗口
            res_Launch = DoctorTest.EditDoctor_ClickCancle(Global.Win_Docker, out string msg25);
            Global.LstInfo.Add(msg25);
            if (!res_Launch) return;

            #endregion

            #region 删除医生
            //点击删除医生按钮，弹出提醒框，选择确定
            res_Launch = DoctorTest.Del_DoctorComfirm(Global.Win_Docker, out string msg26);
            Global.LstInfo.Add(msg26);
            if (!res_Launch) return;

            //点击删除医生按钮，弹出提醒框，选择取消
            res_Launch = DoctorTest.Del_DoctorCancle(Global.Win_Docker, out string msg27);
            Global.LstInfo.Add(msg27);
            if (!res_Launch) return;
            #endregion


            //关闭客户端
            Global.Win_Docker.Close();
        }
    }
}
