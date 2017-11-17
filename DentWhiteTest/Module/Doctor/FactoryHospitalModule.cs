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

namespace DentWhiteTest.Module.Doctor
{
    public class FactoryHospitalModule
    {
        public static void HospitalAllTest()
        {
            Global.LstInfo.Add("--- (技工厂)医院管理模块 ---");

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

            #region 医院列表

            //点击医院管理菜单，加载所有医院
            res_Launch = FactoryHospitalTest.Load_HospitalList(Global.Win_Dentlab, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //输入医院名称，点击查询按钮，加载该医院
            res_Launch = FactoryHospitalTest.Search_HospitalName(Global.Win_Dentlab, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //医院名称为空，点击查询按钮，加载所有医院
            res_Launch = FactoryHospitalTest.Search_HospitalNameNull(Global.Win_Dentlab, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            #endregion

            #region 新增医院

            //新增医院，医院名称为空
            res_Launch = FactoryHospitalTest.AddHospital_NameNull(Global.Win_Dentlab, out string msg4);
            Global.LstInfo.Add(msg4);
            if (!res_Launch) return;

            //新增医院，省份为空
            res_Launch = FactoryHospitalTest.AddHospital_ProvinceNull(Global.Win_Dentlab, out string msg5);
            Global.LstInfo.Add(msg5);
            if (!res_Launch) return;

            //新增医院，市为空
            res_Launch = FactoryHospitalTest.AddHospital_CityNull(Global.Win_Dentlab, out string msg6);
            Global.LstInfo.Add(msg6);
            if (!res_Launch) return;

            //新增医院，区为空
            res_Launch = FactoryHospitalTest.AddHospital_DistrictNull(Global.Win_Dentlab, out string msg7);
            Global.LstInfo.Add(msg7);
            if (!res_Launch) return;

            //新增医院，详细地址为空
            res_Launch = FactoryHospitalTest.AddHospital_DetailNull(Global.Win_Dentlab, out string msg8);
            Global.LstInfo.Add(msg8);
            if (!res_Launch) return;

            //新增医院，选择技工厂为空
            //res_Launch = FactoryHospitalTest.AddHospital_SelectNull(Global.Win_Dentlab, out string msg9);
            //Global.LstInfo.Add(msg9);
            //if (!res_Launch) return;

            //新增医院，上传图片超过5M
            res_Launch = FactoryHospitalTest.AddHospital_uploadBig(Global.Win_Dentlab, out string msg10);
            Global.LstInfo.Add(msg10);
            if (!res_Launch) return;

            //新增医院，增加成功
            res_Launch = FactoryHospitalTest.AddHospital_Succ(Global.Win_Dentlab, out string msg11);
            Global.LstInfo.Add(msg11);
            if (!res_Launch) return;

            //新增医院，点击取消按钮，关闭新增医院窗口
            res_Launch = FactoryHospitalTest.AddHospital_ClickCancle(Global.Win_Dentlab, out string msg12);
            Global.LstInfo.Add(msg12);
            if (!res_Launch) return;
            #endregion

            #region 编辑医院
            //编辑医院，名称为空
            res_Launch = FactoryHospitalTest.EditHospital_HospitalNameNull(Global.Win_Dentlab, out string msg13);
            Global.LstInfo.Add(msg13);
            if (!res_Launch) return;

            //编辑医院，修改医院名称
            res_Launch = FactoryHospitalTest.EditHospital_HospitalNameEdit(Global.Win_Dentlab, out string msg14);
            Global.LstInfo.Add(msg14);
            if (!res_Launch) return;

            //编辑医院，修改省市区
            res_Launch = FactoryHospitalTest.EditHospital_Editcity(Global.Win_Dentlab, out string msg15);
            Global.LstInfo.Add(msg15);
            if (!res_Launch) return;

            //编辑医院，修改详细地址
            res_Launch = FactoryHospitalTest.EditHospital_Detail(Global.Win_Dentlab, out string msg16);
            Global.LstInfo.Add(msg16);
            if (!res_Launch) return;

            //编辑医院，修改技工厂
            //res_Launch = FactoryHospitalTest.EditHospital_Factory(Global.Win_Dentlab, out string msg17);
            //Global.LstInfo.Add(msg17);
            //if (!res_Launch) return;

            //编辑医院，修改上传图片超过5M
            res_Launch = FactoryHospitalTest.EditHospital_UploadImageBeyond(Global.Win_Dentlab, out string msg18);
            Global.LstInfo.Add(msg18);
            if (!res_Launch) return;

            //编辑医院，修改上传图片超过5M
            res_Launch = FactoryHospitalTest.EditHospital_UploadImageBeyond2(Global.Win_Dentlab, out string msg19);
            Global.LstInfo.Add(msg19);
            if (!res_Launch) return;

            //编辑医院，修改上传图片
            res_Launch = FactoryHospitalTest.EditHospital_UploadImage(Global.Win_Dentlab, out string msg20);
            Global.LstInfo.Add(msg20);
            if (!res_Launch) return;
            #endregion

            //关闭客户端
            Global.Win_Dentlab.Close();
        }
    }
}
