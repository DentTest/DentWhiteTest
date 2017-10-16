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

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();
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

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();
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

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();
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

        #region 新增角色

        /// <summary>
        /// 新增角色，角色名称为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddRole_RoleNameBull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddRole = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddRole"));
                btnAddRole.Click();

                //角色名称为空
                TextBox txtRoleName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtRoleName"));
                txtRoleName.Text = "";

                //角色英文别名不为空
                TextBox txtRoleAlias = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtRoleAlias"));
                txtRoleAlias.Text = "en";

                //点击确定按钮
                Button btnComfirmAddRole = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddRole"));
                btnComfirmAddRole.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("角色名称不能为空！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增角色，角色名称为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增角色，角色名称为空】--未通过，缺少角色名称验证提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增角色，角色名称为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增角色，角色英文别名为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddRole_EnRoleNameBull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //角色名称不为空
                TextBox txtRoleName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtRoleName"));
                txtRoleName.BulkText = "角色";

                //角色英文别名为空
                TextBox txtRoleAlias = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtRoleAlias"));
                txtRoleAlias.Text = "";

                //点击确定按钮
                Button btnComfirmAddRole = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddRole"));
                btnComfirmAddRole.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("角色英文别名不能为空！")).ToString();                   
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增角色，角色英文别名为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增角色，角色英文别名为空】--未通过，缺少角色英文别名验证提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增角色，角色英文别名为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增角色成功，同时关闭新增角色窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddRoleSucc(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //角色名称不为空
                TextBox txtRoleName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtRoleName"));
                txtRoleName.BulkText = "角色";

                //角色英文别名为空
                TextBox txtRoleAlias = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtRoleAlias"));
                txtRoleAlias.Text = "juese";

                //点击确定按钮
                Button btnComfirmAddRole = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddRole"));
                btnComfirmAddRole.Click();

                var endTime = DateTime.Now;

                try
                {                    
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string succ_info = appWin.Get<Label>(SearchCriteria.ByText("新增成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //捕捉新增角色窗口，如果能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增角色")).ToString();

                    msg = "测试【新增角色成功，同时关闭新增角色窗口】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
                catch
                {
                    msg = "测试【新增角色成功，同时关闭新增角色窗口】--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增角色成功，同时关闭新增角色窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增角色，点击取消按钮，关闭新增角色窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddRole_ClickCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddRole = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddRole"));
                btnAddRole.Click();

                //点击取消按钮
                Button btnCancleAddRole = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleAddRole"));
                btnCancleAddRole.Click();

                var endTime = DateTime.Now;

                try
                {

                    //捕捉新增角色窗口，如果能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增角色")).ToString();

                    msg = "测试【新增角色，点击取消按钮，关闭新增角色窗口】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增角色，点击取消按钮，关闭新增角色窗口】--未通过，未关闭新增窗口。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增角色，点击取消按钮，关闭新增角色窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region 编辑角色

        #endregion
    }
}
