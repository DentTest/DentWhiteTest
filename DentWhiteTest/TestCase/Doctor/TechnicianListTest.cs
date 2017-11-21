using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.ListBoxItems;
using DentWhiteTest.Helper;
using System.Threading;

namespace DentWhiteTest.TestCase
{
    public class TechnicianListTest
    {
        #region 订单列表

        /// <summary>
        /// 点击订单列表，显示所有订单
        /// </summary>
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

        /// <summary>
        /// 输入单号，点击查询按钮，加载该单号
        /// </summary>
        public static bool Search_OrderID(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //输入订单单号
                TextBox txtOrderSn = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtOrderSn"));
                txtOrderSn.BulkText = "1711141356185888";

                //点击查询按钮
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询订单列表异常！")).ToString();

                    btnSearchOrderList.Click();

                    error_info = appWin.Get<Label>(SearchCriteria.ByText("查询订单列表异常！")).ToString();

                    msg = "测试【输入订单单号，点击查询按钮，加载该订单】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入订单单号，点击查询按钮，加载该订单】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【输入订单单号，点击查询按钮，加载该订单】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 订单ID为空，点击查询按钮，加载所有订单
        /// </summary>
        public static bool Search_OrderIDNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //订单ID为空
                TextBox txtOrderSn = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtOrderSn"));
                txtOrderSn.Text = "";

                //点击查询按钮
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询订单列表异常！")).ToString();
                    msg = "测试【订单ID为空，点击查询按钮，加载所有订单】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【订单ID为空，点击查询按钮，加载所有订单】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【订单ID为空，点击查询按钮，加载所有订单】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 根据订单状态，点击查询，加载该状态的订单
        /// cbOrderListSearch_orderstatus
        /// </summary>
        public static bool Search_Statusl(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //订单ID为空
                TextBox txtOrderSn = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtOrderSn"));
                txtOrderSn.Text = "";

                //选择订单状态
                ComboBox cbStatusName = appWin.Get<ComboBox>(SearchCriteria.ByAutomationId("cbStatusName"));
                cbStatusName.Select(2);

                //点击查询按钮
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询订单列表异常！")).ToString();
                    msg = "测试【选择订单状态，点击查询按钮，加载该状态的所有订单】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【选择订单状态，点击查询按钮，加载该状态的所有订单】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【选择订单状态，点击查询按钮，加载该状态的所有订单】--失败，原因：" + e.ToString();
                return false;
            }
        }


        /// <summary>
        /// 输入医生名称，点击查询按钮，加载该医生单号
        /// </summary>
        public static bool Search_DoctorName(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //刷新
                Button btnRefreshOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnRefreshOrderList"));
                btnRefreshOrderList.Click();

                //医生名称
                TextBox txtDoctorName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.Text = "lbw";

                //点击查询按钮
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询订单列表异常！")).ToString();
                    msg = "测试【医生名称，点击查询按钮，加载该医生订单】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【医生名称，点击查询按钮，加载该医生订单】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【医生名称，点击查询按钮，加载该医生订单】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 订单ID为空，点击查询按钮，加载所有订单
        /// </summary>
        public static bool Search_UniqueNumber(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //刷新
                Button btnRefreshOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnRefreshOrderList"));
                btnRefreshOrderList.Click();

                //医生名称
                TextBox txtUniqueNumber = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtUniqueNumber"));
                txtUniqueNumber.Text = "1711141";

                //点击查询按钮
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询订单列表异常！")).ToString();
                    msg = "测试【生产批号，点击查询按钮，加载该医生订单】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【生产批号，点击查询按钮，加载该医生订单】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【生产批号，点击查询按钮，加载该医生订单】--失败，原因：" + e.ToString();
                return false;
            }
        }
        #endregion

    }

}
