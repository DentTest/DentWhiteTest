using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace DentWhiteTest.TestCase
{
    public class HospitalTest
    {
        #region 医院列表

        /// <summary>
        /// 点击医院管理菜单，加载所有医院
        /// </summary>
        public static bool Load_HospitalList(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //在菜单页选择医院管理
                Button tlHospitalManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlHospitalManagement"));
                tlHospitalManagement.Click();
                var endTime = DateTime.Now;

                msg = "测试【点击医院管理菜单，加载所有医院】--通过，用时：" + (endTime - startTime).TotalSeconds;
                return true;
            }
            catch (Exception e)
            {
                msg = "测试【点击医院管理菜单，加载所有医院】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入医院名称，点击查询按钮，加载该医院
        /// </summary>
        public static bool Search_HospitalName(Window appWin, out string msg)
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
                msg = "测试【输入医院名称，点击查询按钮，加载该医院】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 医院名称为空，点击查询按钮，加载所有医院
        /// </summary>
        public static bool Search_HospitalNameNull(Window appWin, out string msg)
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
                msg = "测试【医院名称为空，点击查询按钮，加载所有医院】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion
    }
}
