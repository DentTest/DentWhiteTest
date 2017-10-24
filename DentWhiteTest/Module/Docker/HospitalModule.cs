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

            #region 医院列表

            //点击医院管理菜单，加载所有医院
            res_Launch = HospitalTest.Load_HospitalList(Global.Win_Docker, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //输入医院名称，点击查询按钮，加载该医院
            res_Launch = HospitalTest.Search_HospitalName(Global.Win_Docker, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //医院名称为空，点击查询按钮，加载所有医院
            res_Launch = HospitalTest.Search_HospitalNameNull(Global.Win_Docker, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            #endregion

            //新增医院，医院名称为空
            res_Launch = HospitalTest.AddHospital_NameNull(Global.Win_Docker, out string msg4);
            Global.LstInfo.Add(msg4);
            if (!res_Launch) return;

            //新增医院，省份为空
            res_Launch = HospitalTest.AddHospital_ProvinceNull(Global.Win_Docker, out string msg5);
            Global.LstInfo.Add(msg5);
            if (!res_Launch) return;

            //新增医院，市为空
            res_Launch = HospitalTest.AddHospital_CityNull(Global.Win_Docker, out string msg6);
            Global.LstInfo.Add(msg6);
            if (!res_Launch) return;

            //新增医院，区为空
            res_Launch = HospitalTest.AddHospital_DistrictNull(Global.Win_Docker, out string msg7);
            Global.LstInfo.Add(msg7);
            if (!res_Launch) return;

            //新增医院，详细地址为空
            res_Launch = HospitalTest.AddHospital_DetailNull(Global.Win_Docker, out string msg8);
            Global.LstInfo.Add(msg8);
            if (!res_Launch) return;

            //新增医院，上传图片超过5M
            res_Launch = HospitalTest.AddHospital_uploadBig(Global.Win_Docker, out string msg9);
            Global.LstInfo.Add(msg9);
            if (!res_Launch) return;

            //新增医院，增加成功
            res_Launch = HospitalTest.AddHospital_Succ(Global.Win_Docker, out string msg10);
            Global.LstInfo.Add(msg10);
            if (!res_Launch) return;

            //新增医院，点击取消按钮，关闭新增医院窗口
            res_Launch = HospitalTest.AddHospital_ClickCancle(Global.Win_Docker, out string msg11);
            Global.LstInfo.Add(msg11);
            if (!res_Launch) return;

            #region


            #endregion


            //关闭客户端
            Global.Win_Docker.Close();
        }
    }
}
