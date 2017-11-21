using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentWhiteTest.Helper;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.ListBoxItems;
using System.Threading;

namespace DentWhiteTest.TestCase.Doctor
{
    public class UploadReportTest 
    {
        public static bool Load_OrderList(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //在菜单页选择订单列表
                Button tlOrderListModule = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlOrderListModule"));
                tlOrderListModule.Click();
                var endTime = DateTime.Now;

                msg = "测试【点击订单列表，加载所有订单】--通过，用时：" + (endTime - startTime).TotalSeconds;
                return true;
            }
            catch (Exception e)
            {
                msg = "测试【点击订单列表，加载所有订单】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #region 上传报告
        /// <summary>
        /// 上传报告
        /// </summary>
        public static bool UpLoad_OrderReport(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //直接进入订单列表，点击上传报告
                Button btnImportProgramme = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnImportProgramme"));
                btnImportProgramme.Click();


                //点击浏览
                Button btnBrowseReportFile = appWin.MdiChild(SearchCriteria.ByAutomationId("ProgrammeImportView")).Get<Button>(SearchCriteria.ByAutomationId("btnBrowseReportFile"));
                btnBrowseReportFile.Click();

                //上传图片
                var selectWinA = appWin.MdiChild(SearchCriteria.ByText("浏览文件夹"));
                var report = appWin.MdiChild(SearchCriteria.ByText("report"));
                report.Click();
                Button btn = selectWinA.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn.Click();
                Button btnConfirmImport = appWin.MdiChild(SearchCriteria.ByAutomationId("ProgrammeImportView")).Get<Button>(SearchCriteria.ByAutomationId("btnConfirmImport"));
                btnConfirmImport.Click();

                try
                {
                    Thread.Sleep(2000);
                    //捕捉提醒信息，如果能铺捉到，则测试通过
                    var Reporttips = appWin.MdiChild(SearchCriteria.ByText("系统正在打包报告，打包完成后会自动上传。"));
                    btn = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btn.Click();

                    msg = "测试【上传报告】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
                catch
                {
                    msg = "测试【上传报告】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【上传报告】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 上传报告,缺少xml文件
        /// </summary>
        public static bool UpLoad_OrderReportXMLNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //直接进入订单列表，点击上传报告
                Button btnImportProgramme = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnImportProgramme"));
                btnImportProgramme.Click();


                //点击浏览
                Button btnBrowseReportFile = appWin.MdiChild(SearchCriteria.ByAutomationId("ProgrammeImportView")).Get<Button>(SearchCriteria.ByAutomationId("btnBrowseReportFile"));
                btnBrowseReportFile.Click();

                //上传图片
                var selectWinA = appWin.MdiChild(SearchCriteria.ByText("浏览文件夹"));
                var report = selectWinA.Get(SearchCriteria.ByText("reportxml"));
                report.Click();
                Button btn = selectWinA.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn.Click();
                Button btnConfirmImport = appWin.MdiChild(SearchCriteria.ByAutomationId("ProgrammeImportView")).Get<Button>(SearchCriteria.ByAutomationId("btnConfirmImport"));
                btnConfirmImport.Click();

                try
                {
                    Thread.Sleep(2000);
                    //捕捉提醒信息，如果能铺捉到，则测试通过
                    var Reporttips = appWin.MdiChild(SearchCriteria.ByText("缺少文件，不能打包！"));
                    btn = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btn.Click();

                    msg = "测试【上传报告,缺少xml文件】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
                catch
                {
                    msg = "测试【上传报告,缺少xml文件】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【上传报告,缺少xml文件】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 上传报告,缺少xls文件
        /// </summary>
        public static bool UpLoad_OrderReportXLSNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //直接进入订单列表，点击上传报告
                Button btnImportProgramme = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnImportProgramme"));
                btnImportProgramme.Click();


                //点击浏览
                Button btnBrowseReportFile = appWin.MdiChild(SearchCriteria.ByAutomationId("ProgrammeImportView")).Get<Button>(SearchCriteria.ByAutomationId("btnBrowseReportFile"));
                btnBrowseReportFile.Click();

                //上传图片
                var selectWinA = appWin.MdiChild(SearchCriteria.ByText("浏览文件夹"));
                var report = selectWinA.Get(SearchCriteria.ByText("reportxls"));
                report.Click();
                Button btn = selectWinA.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn.Click();
                Button btnConfirmImport = appWin.MdiChild(SearchCriteria.ByAutomationId("ProgrammeImportView")).Get<Button>(SearchCriteria.ByAutomationId("btnConfirmImport"));
                btnConfirmImport.Click();

                try
                {
                    Thread.Sleep(2000);
                    //捕捉提醒信息，如果能铺捉到，则测试通过
                    var Reporttips = appWin.MdiChild(SearchCriteria.ByText("缺少文件，不能打包！"));
                    btn = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btn.Click();

                    msg = "测试【上传报告,缺少xls文件】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
                catch
                {
                    msg = "测试【上传报告,缺少xls文件】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【上传报告,缺少xls文件】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 上传报告,缺少pdf文件
        /// </summary>
        public static bool UpLoad_OrderReportPDFNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //直接进入订单列表，点击上传报告
                Button btnImportProgramme = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnImportProgramme"));
                btnImportProgramme.Click();


                //点击浏览
                Button btnBrowseReportFile = appWin.MdiChild(SearchCriteria.ByAutomationId("ProgrammeImportView")).Get<Button>(SearchCriteria.ByAutomationId("btnBrowseReportFile"));
                btnBrowseReportFile.Click();

                //上传图片
                var selectWinA = appWin.MdiChild(SearchCriteria.ByText("浏览文件夹"));
                var report = selectWinA.Get(SearchCriteria.ByText("reportpdf"));
                report.Click();
                Button btn = selectWinA.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn.Click();
                Button btnConfirmImport = appWin.MdiChild(SearchCriteria.ByAutomationId("ProgrammeImportView")).Get<Button>(SearchCriteria.ByAutomationId("btnConfirmImport"));
                btnConfirmImport.Click();

                try
                {
                    Thread.Sleep(2000);
                    //捕捉提醒信息，如果能铺捉到，则测试通过
                    var Reporttips = appWin.MdiChild(SearchCriteria.ByText("缺少文件，不能打包！"));
                    btn = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btn.Click();

                    msg = "测试【上传报告,缺少pdf文件】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
                catch
                {
                    msg = "测试【上传报告,缺少pdf文件】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【上传报告,缺少pdf文件】--失败，原因：" + e.ToString();
                return false;
            }
        }
        #endregion
    }
 }
