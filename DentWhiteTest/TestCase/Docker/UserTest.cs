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

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询用户列表异常！")).ToString();
                    msg = "测试【点击用户管理菜单，加载所有用户】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【点击用户管理菜单，加载所有用户】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
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

                //输入用户名称
                TextBox txtSearchUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtSearchUser"));
                txtSearchUser.BulkText = "超级管理员";

                //点击查询按钮
                Button btnSearch = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearch"));
                btnSearch.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询用户列表异常！")).ToString();
                    msg = "测试【输入用户名称，点击查询按钮，加载该用户】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入用户名称，点击查询按钮，加载该用户】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
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

                //用户名称为空
                TextBox txtSearchUser = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtSearchUser"));
                txtSearchUser.Text = "";

                //点击查询按钮
                Button btnSearch = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearch"));
                btnSearch.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询用户列表异常！")).ToString();
                    msg = "测试【用户名称为空，点击查询按钮，加载所有用户】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【用户名称为空，点击查询按钮，加载所有用户】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
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
