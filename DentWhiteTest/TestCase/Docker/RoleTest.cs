using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace DentWhiteTest.TestCase
{
    public class RoleTest
    {
        #region 角色列表

        /// <summary>
        /// 点击角色管理菜单，加载所有角色
        /// </summary>
        public static bool Load_RoleList(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //在菜单页选择角色管理
                Button tlRoleManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlRoleManagement"));
                tlRoleManagement.Click();

                var endTime = DateTime.Now;

                string error_info = string.Empty;
                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();
                    msg = "测试【点击角色管理菜单，加载所有角色】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【点击角色管理菜单，加载所有角色】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【点击角色管理菜单，加载所有角色】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入角色名称，点击查询按钮，加载该角色
        /// </summary>
        public static bool Search_RoleName(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //输入角色名称
                TextBox txtSearchRole = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtSearchRole"));
                txtSearchRole.BulkText = "超级管理员";

                //点击查询按钮
                Button btnSearch = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearch"));
                btnSearch.Click();

                var endTime = DateTime.Now;

                string error_info = string.Empty;
                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();
                    msg = "测试【输入角色名称，点击查询按钮，加载该角色】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入角色名称，点击查询按钮，加载该角色】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【输入角色名称，点击查询按钮，加载该角色】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 角色名称为空，点击查询按钮，加载所有角色
        /// </summary>
        public static bool Search_RoleNameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //角色名称为空
                TextBox txtSearchRole = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtSearchRole"));
                txtSearchRole.Text = "";

                //点击查询按钮
                Button btnSearch = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearch"));
                btnSearch.Click();

                var endTime = DateTime.Now;

                string error_info = string.Empty;
                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();
                    msg = "测试【角色名称为空，点击查询按钮，加载所有角色】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【角色名称为空，点击查询按钮，加载所有角色】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【角色名称为空，点击查询按钮，加载所有角色】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion
    }
}
