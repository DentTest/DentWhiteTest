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

                //输入医生名称
                TextBox txtDoctorName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = "医生名称";

                //点击查询
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();
                    msg = "测试【输入医生名称，点击查询按钮，加载该医生】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入医生名称，点击查询按钮，加载该医生】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
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

                //输入医生名称为空
                TextBox txtDoctorName = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.BulkText = "";

                //点击查询
                Button btnSearchOrderList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchOrderList"));
                btnSearchOrderList.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();
                    msg = "测试【输入医生名称，点击查询按钮，加载该医生】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入医生名称，点击查询按钮，加载该医生】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【医生名称为空，点击查询按钮，加载所有医生】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region 新增医生（所有id都还没完整）
        /// <summary>
        /// 新增医生，医生名称为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        /// 增加按钮：btnAddDoctor
        public static bool AddRole_DoctorNameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddDoctor"));
                btnAddDoctor.Click();

                //角色名称为空
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditRoleView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.Text = "";

                //角色英文别名不为空
                TextBox txtDoctorAlias = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditRoleView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorAlias"));
                txtDoctorAlias.Text = "en";

                //点击确定按钮
                Button btnComfirmAddRole = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddRole"));
                btnComfirmAddRole.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("医生名称不能为空！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医生，医生名称为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医生，医生名称为空】--未通过，缺少角色名称验证提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医生，医生名称为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医生，医生英文名称为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        /// 增加按钮：btnAddDoctor
        public static bool AddRole_AliasNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddDoctor"));
                btnAddDoctor.Click();

                //角色名称为空
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditRoleView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.Text = "南方医生";

                //角色英文别名不为空
                TextBox txtDoctorAlias = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditRoleView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorAlias"));
                txtDoctorAlias.Text = "";

                //点击确定按钮
                Button btnComfirmAddRole = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddRole"));
                btnComfirmAddRole.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("医生英文名称不能为空！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医生，医生英文名称为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医生，医生英文名称为空】--未通过，缺少角色名称验证提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医生，医生英文名称为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医生成功，同时关闭新增医生窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        /// 增加按钮：btnAddDoctor
        public static bool AddRole_DoctorSucc(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddDoctor = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddDoctor"));
                btnAddDoctor.Click();

                //医生名称
                TextBox txtDoctorName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditRoleView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorName"));
                txtDoctorName.Text = "南方医生";

                //医生英文名称
                TextBox txtDoctorAlias = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditRoleView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtDoctorAlias"));
                txtDoctorAlias.Text = "doctor";

                //点击确定按钮
                Button btnComfirmAddRole = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddRole"));
                btnComfirmAddRole.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("医生英文名称不能为空！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医生，医生英文名称为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医生，医生英文名称为空】--未通过，缺少角色名称验证提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医生，医生英文名称为空】--失败，原因：" + e.ToString();
                return false;
            }
        }
        #endregion



    }
}
