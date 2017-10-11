using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace DentWhiteTest.TestCase
{
    public class DoctorTest
    {
        #region 医生列表

        /// <summary>
        /// 点击医生管理菜单，加载所有医生
        /// </summary>
        public static bool Load_DoctorList(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //在菜单页选择医生管理
                Button tlDoctorManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlDoctorManagement"));
                tlDoctorManagement.Click();
                var endTime = DateTime.Now;

                msg = "测试【点击医生管理菜单，加载所有医生】--通过，用时：" + (endTime - startTime).TotalSeconds;
                return true;
            }
            catch (Exception e)
            {
                msg = "测试【点击医生管理菜单，加载所有医生】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入医生名称，点击查询按钮，加载该医生
        /// </summary>
        public static bool Search_DoctorName(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;


                var endTime = DateTime.Now;

                msg = "";
                return true;
            }
            catch (Exception e)
            {
                msg = "测试【输入医生名称，点击查询按钮，加载该医生】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 医生名称为空，点击查询按钮，加载所有医生
        /// </summary>
        public static bool Search_DoctorNameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;


                var endTime = DateTime.Now;

                msg = "";
                return true;
            }
            catch (Exception e)
            {
                msg = "测试【医生名称为空，点击查询按钮，加载所有医生】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion
    }
}
