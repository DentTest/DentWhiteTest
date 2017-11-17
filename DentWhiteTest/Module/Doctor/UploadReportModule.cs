using DentWhiteTest.Common;
using DentWhiteTest.Contacts;
using DentWhiteTest.TestCase.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;

namespace DentWhiteTest.Module.Doctor
{
    public class UploadReportModule
    {
        public static void DoctorAllTest()
        {
            Global.LstInfo.Add("--- 上传报告 ---");

            //启动一个客户端
            bool res_Launch = WinHelp.Launch(out Window appWin, out string msg, Const.DoctorPath, Const.DoctorClientName, Const.DoctorId);
            Global.LstInfo.Add(msg);
            if (res_Launch)
            {
                Global.Win_Dentlab = appWin;

                //启动成功，登录
                var _login = LoginDoctorTest.LoginTechnician_Success(Global.Win_Dentlab, out string msg_login);
                Global.LstInfo.Add(msg_login);
                //如果登录失败，返回
                if (!_login) return;
            }
            else
            {
                return;
            }
            #region 上传报告

            //点击订单列表
            res_Launch = UploadReportTest.Load_OrderList(Global.Win_Dentlab, out string msg5);
            Global.LstInfo.Add(msg5);
            if (!res_Launch) return;

            
            //上传报告缺少XML文件
            res_Launch = UploadReportTest.UpLoad_OrderReportXMLNull(Global.Win_Dentlab, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //上传报告缺少XLS文件
            res_Launch = UploadReportTest.UpLoad_OrderReportXLSNull(Global.Win_Dentlab, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            //上传报告缺少PDF文件
            res_Launch = UploadReportTest.UpLoad_OrderReportPDFNull(Global.Win_Dentlab, out string msg4);
            Global.LstInfo.Add(msg4);
            if (!res_Launch) return;

            //上传报告成功
            res_Launch = UploadReportTest.UpLoad_OrderReport(Global.Win_Dentlab, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            #endregion

            //关闭客户端
            Global.Win_Dentlab.Close();
        }
    }
}
