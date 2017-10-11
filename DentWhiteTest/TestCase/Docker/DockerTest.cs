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
    public class DockerTest
    {
        #region 排牙师列表

        /// <summary>
        /// 点击排牙师管理菜单，加载所有排牙师
        /// </summary>
        public static bool Load_DockerList(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //在菜单页选择排牙师管理
                Button tlDockerManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlDockerManagement"));
                tlDockerManagement.Click();
                var endTime = DateTime.Now;

                msg = "测试【点击排牙师管理菜单，加载所有排牙师】--通过，用时：" + (endTime - startTime).TotalSeconds;
                return true;
            }
            catch (Exception e)
            {
                msg = "测试【点击排牙师管理菜单，加载所有排牙师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入排牙师名称，点击查询按钮，加载该排牙师
        /// </summary>
        public static bool Search_DockerName(Window appWin, out string msg)
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
                msg = "测试【输入排牙师名称，点击查询按钮，加载该排牙师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 排牙师名称为空，点击查询按钮，加载所有排牙师
        /// </summary>
        public static bool Search_DockerNameNull(Window appWin, out string msg)
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
                msg = "测试【排牙师名称为空，点击查询按钮，加载所有排牙师】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion
    }
}
