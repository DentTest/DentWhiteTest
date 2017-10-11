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
    public class UserTest
    {
        #region 用户列表

        /// <summary>
        /// 点击用户管理菜单，加载所有用户
        /// </summary>
        public static bool Load_UserList(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //在菜单页选择用户管理
                Button tlUsersManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlUsersManagement"));
                tlUsersManagement.Click();
                var endTime = DateTime.Now;

                msg = "测试【点击用户管理菜单，加载所有用户】--通过，用时：" + (endTime - startTime).TotalSeconds;
                return true;
            }
            catch (Exception e)
            {
                msg = "测试【点击用户管理菜单，加载所有用户】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入用户名称，点击查询按钮，加载该用户
        /// </summary>
        public static bool Search_UserName(Window appWin, out string msg)
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
                msg = "测试【输入用户名称，点击查询按钮，加载该用户】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 用户名称为空，点击查询按钮，加载所有用户
        /// </summary>
        public static bool Search_UserNameNull(Window appWin, out string msg)
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
                msg = "测试【用户名称为空，点击查询按钮，加载所有用户】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion
    }
}
