using DentWhiteTest.Helper;
using System;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.ListBoxItems;
using System.Threading;

namespace DentWhiteTest.TestCase.Docker
{
    public class FactoryTest
    {
        #region 技工厂列表

        /// <summary>
        /// 点击技工厂管理菜单，加载所有技工厂
        /// </summary>
        public static bool Load_FactoryList(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //在菜单页选择技工厂管理
                Button tlFactoryManagement = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlFactoryManagement"));
                tlFactoryManagement.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询技工厂列表异常！")).ToString();
                    msg = "测试【点击技工厂管理菜单，加载所有技工厂】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【点击技工厂管理菜单，加载所有技工厂】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【点击技工厂管理菜单，加载所有技工厂】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 输入工厂名称，点击查询按钮，加载该技工厂
        /// </summary>
        public static bool Search_FactoryName(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //输入工厂名称
                TextBox txtSearchFactory = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtSearchFactory"));

                appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SHIFT);
                Thread.Sleep(1000);
                txtSearchFactory.Text = "admin";
                //appWin.Keyboard.PressSpecialKey(TestStack.White.WindowsAPI.KeyboardInput.SpecialKeys.SPACE);


                //点击查询按钮
                Button btnSearchFactoryrList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchFactoryrList"));
                btnSearchFactoryrList.Click();

                var endTime = DateTime.Now;

                try
                {
                    Thread.Sleep(300);
                    //捕捉提醒信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询技工厂列表异常！")).ToString();
                    msg = "测试【输入技工厂名称，点击查询按钮，加载该技工厂】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入技工厂名称，点击查询按钮，加载该技工厂】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【输入技工厂名称，点击查询按钮，加载该技工厂】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 技工厂名称为空，点击查询按钮，加载所有技工厂
        /// </summary>
        public static bool Search_FactoryNameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //技工厂名称为空
                TextBox txtSearchFactory = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtSearchFactory"));
                txtSearchFactory.Text = "";

                //点击查询按钮
                Button btnSearchFactoryrList = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearchFactoryrList"));
                btnSearchFactoryrList.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询技工厂列表异常！")).ToString();
                    msg = "测试【技工厂名称为空，点击查询按钮，加载所有技工厂】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【技工厂名称为空，点击查询按钮，加载所有技工厂】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【技工厂名称为空，点击查询按钮，加载所有技工厂】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region 新增技工厂

        /// <summary>
        /// 新增技工厂，工厂名称为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddFactory_FactoryNameBull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddFactory"));
                btnAddFactory.Click();

                //工厂名称为空
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.Text = "";

                //点击确定按钮
                Button btnComfirmAddFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddFactory"));
                btnComfirmAddFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入工厂名称！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增技工厂，工厂名称为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增技工厂，工厂名称为空】--未通过，缺少工厂名称空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技工厂，工厂名称为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技工厂，工厂名称多于50个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddFactory_FactoryNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //工厂名称多于50个字符
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.BulkText = Generate.GenerateChineseWords(51);

                //点击确定按钮
                Button btnComfirmAddFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddFactory"));
                btnComfirmAddFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("工厂名称最多50个字！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增技工厂，工厂名称多于50个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
                catch
                {
                    msg = "测试【新增技工厂，工厂名称多于50个字】--未通过，缺少工厂名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }

            }
            catch (Exception e)
            {
                msg = "测试【新增技工厂，工厂名称多于50个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技工厂，地址为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddFactory_AddressNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //工厂名称不为空
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.BulkText = Generate.GenerateChineseWords(5);

                //地址为空
                TextBox txtAddress = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtAddress"));
                txtAddress.Text = "";

                //点击确定按钮
                Button btnComfirmAddFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddFactory"));
                btnComfirmAddFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入地址！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增技工厂，地址为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增技工厂，地址为空】--未通过，缺少地址为空提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技工厂，地址为空】--失败，原因：" + e.ToString();
                return false;
            }
        }


        /// <summary>
        /// 新增技工厂，地址多于150个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddFactory_AddressLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //工厂名称不为空
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.BulkText = Generate.GenerateChineseWords(5);

                //地址多于150个字
                TextBox txtAddress = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtAddress"));
                txtAddress.BulkText = Generate.GenerateChineseWords(151);

                //点击确定按钮
                Button btnComfirmAddFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddFactory"));
                btnComfirmAddFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("地址最多150个字！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增技工厂，地址多于150个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增技工厂，地址多于150个字】--未通过，缺少地址长度验证。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技工厂，地址多于150个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技工厂，电话为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddFactory_PhoneNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //工厂名称不为空
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.BulkText = Generate.GenerateChineseWords(5);

                //地址多于150个字
                TextBox txtAddress = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtAddress"));
                txtAddress.BulkText = Generate.GenerateChineseWords(15);

                //点击确定按钮
                Button btnComfirmAddFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddFactory"));
                btnComfirmAddFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请填写电话！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增技工厂，电话为空】--通过,用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增技工厂，电话为空】--未通过，缺少电话空验证，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技工厂，电话为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技工厂，负责人为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddFactory_ManagerNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //工厂名称不为空
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.BulkText = Generate.GenerateChineseWords(5);

                //地址多于150个字
                TextBox txtAddress = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtAddress"));
                txtAddress.BulkText = Generate.GenerateChineseWords(15);

                //电话不为空
                TextBox txtTel = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTel"));
                txtTel.Text = "13215552001";

                //点击确定按钮
                Button btnComfirmAddFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddFactory"));
                btnComfirmAddFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入负责人！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增技工厂，负责人为空】--通过,用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增技工厂，负责人为空】--未通过，缺少负责人空验证，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技工厂，负责人为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技工厂成功，同时关闭新增技工厂窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddFactorySucc(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //工厂名称不为空
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.BulkText = Generate.GenerateChineseWords(5);

                //地址多于150个字
                TextBox txtAddress = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtAddress"));
                txtAddress.BulkText = Generate.GenerateChineseWords(15);

                //电话不为空
                TextBox txtTel = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTel"));
                txtTel.Text = "13215552001";

                //负责人不为空
                TextBox txtManager = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtManager"));
                txtManager.BulkText = Generate.GenerateChineseWords(3);

                //点击确定按钮
                Button btnComfirmAddFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddFactory"));
                btnComfirmAddFactory.Click();

                try
                {
                    //捕捉提醒信息，如果不能捕捉到，则测试不通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("新增成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    try
                    {
                        //捕捉新增技工厂窗口，如果不能捕捉到，则测试通过
                        string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增工厂")).ToString();

                        msg = "测试【新增技工厂成功，同时关闭新增技工厂窗口】--未通过，未关闭新增技工厂窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                    catch
                    {
                        msg = "测试【新增技工厂成功，同时关闭新增技工厂窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                        return true;
                    }
                }
                catch
                {
                    msg = "测试【新增技工厂成功，同时关闭新增技工厂窗口】-未通过。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技工厂成功，同时关闭新增技工厂窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增技工厂，点击取消按钮，关闭新增技工厂窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddFactory_ClickCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddFactory"));
                btnAddFactory.Click();

                //点击取消按钮
                Button btnCancleAddFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleAddFactory"));
                btnCancleAddFactory.Click();

                try
                {
                    //捕捉新增技工厂窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增工厂")).ToString();
                    msg = "测试【新增技工厂，点击取消按钮，关闭新增技工厂窗口】--未通过，未关闭新增窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【新增技工厂，点击取消按钮，关闭新增技工厂窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增技工厂，点击取消按钮，关闭新增技工厂窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region 编辑技工厂

        /// <summary>
        /// 编辑技工厂，无修改操作，点击确定按钮
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditFactory_NoEdit(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnAddFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditFactory").AndIndex(1));
                btnAddFactory.Click();

                //点击确定按钮
                Button btnComfirmEditFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditFactory"));
                btnComfirmEditFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //捕捉编辑技工厂窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑工厂")).ToString();

                    msg = "测试【编辑技工厂，无修改操作，点击确定按钮】--未通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【编辑技工厂，无修改操作，点击确定按钮】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技工厂，无修改操作，点击确定按钮】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技工厂，点击取消按钮，关闭编辑技工厂窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditFactory_ClickCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditFactory").AndIndex(1));
                btnEditFactory.Click();

                //点击取消按钮
                Button btnCancleEditFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleEditFactory"));
                btnCancleEditFactory.Click();

                try
                {
                    //捕捉编辑技工厂窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("编辑工厂")).ToString();
                    msg = "测试【编辑技工厂，点击取消按钮，关闭编辑技工厂窗口】--未通过，未关闭编辑窗口。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【编辑技工厂，点击取消按钮，关闭编辑技工厂窗口】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技工厂，点击取消按钮，关闭编辑技工厂窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技工厂，工厂名称为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditFactory_FactoryNameBull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击编辑按钮
                Button btnEditFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnEditFactory"));
                btnEditFactory.Click();

                //工厂名称为空
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.Text = "";

                //点击确定按钮
                Button btnComfirmEditFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditFactory"));
                btnComfirmEditFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入工厂名称！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑技工厂，工厂名称为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑技工厂，工厂名称为空】--未通过，缺少工厂名称空验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技工厂，工厂名称为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技工厂，工厂名称多于50个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditFactory_FactoryNameLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //工厂名称多于50个字符
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.BulkText = Generate.GenerateChineseWords(51);

                //点击确定按钮
                Button btnComfirmEditFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditFactory"));
                btnComfirmEditFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("工厂名称最多50个字！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑技工厂，工厂名称多于50个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;
                }
                catch
                {
                    msg = "测试【编辑技工厂，工厂名称多于50个字】--未通过，缺少工厂名称长度验证提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }

            }
            catch (Exception e)
            {
                msg = "测试【编辑技工厂，工厂名称多于50个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技工厂，地址为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditFactory_AddressNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //工厂名称不为空
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.BulkText = Generate.GenerateChineseWords(5);

                //地址为空
                TextBox txtAddress = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtAddress"));
                txtAddress.Text = "";

                //点击确定按钮
                Button btnComfirmEditFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditFactory"));
                btnComfirmEditFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入地址！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑技工厂，地址为空】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑技工厂，地址为空】--未通过，缺少地址为空提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技工厂，地址为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技工厂，地址多于150个字
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditFactory_EditressLength(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //工厂名称不为空
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.BulkText = Generate.GenerateChineseWords(5);

                //地址多于150个字
                TextBox txtAddress = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtAddress"));
                txtAddress.BulkText = Generate.GenerateChineseWords(151);

                //点击确定按钮
                Button btnComfirmEditFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditFactory"));
                btnComfirmEditFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("地址最多150个字！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑技工厂，地址多于150个字】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑技工厂，地址多于150个字】--未通过，缺少地址长度验证。用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技工厂，地址多于150个字】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技工厂，电话为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditFactory_PhoneNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //工厂名称不为空
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.BulkText = Generate.GenerateChineseWords(5);

                //地址
                TextBox txtAddress = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtAddress"));
                txtAddress.BulkText = Generate.GenerateChineseWords(15);

                //电话为空
                TextBox txtTel = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTel"));
                txtTel.Text = "";

                //点击确定按钮
                Button btnComfirmEditFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditFactory"));
                btnComfirmEditFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请填写电话！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑技工厂，电话为空】--通过,用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑技工厂，电话为空】--未通过，缺少电话空验证，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技工厂，电话为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技工厂，负责人为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditFactory_ManagerNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //工厂名称不为空
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.BulkText = Generate.GenerateChineseWords(5);

                //地址多于150个字
                TextBox txtAddress = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtAddress"));
                txtAddress.BulkText = Generate.GenerateChineseWords(15);

                //电话不为空
                TextBox txtTel = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTel"));
                txtTel.Text = "13215552001";

                //负责人为空
                TextBox txtManager = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtManager"));
                txtManager.Text = "";

                //点击确定按钮
                Button btnComfirmEditFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditFactory"));
                btnComfirmEditFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("请输入负责人！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑技工厂，负责人为空】--通过,用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑技工厂，负责人为空】--未通过，缺少负责人空验证，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技工厂，负责人为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 编辑技工厂成功
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool EditFactory_Succ(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //工厂名称不为空
                TextBox txtFactoryName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtFactoryName"));
                txtFactoryName.BulkText = Generate.GenerateChineseWords(5);

                //地址
                TextBox txtAddress = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtAddress"));
                txtAddress.BulkText = Generate.GenerateChineseWords(15);

                //电话不为空
                TextBox txtTel = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtTel"));
                txtTel.Text = "13215552001";

                //负责人为空
                TextBox txtManager = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditFactoryView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtManager"));
                txtManager.BulkText = Generate.GenerateChineseWords(3);

                //点击确定按钮
                Button btnComfirmEditFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmEditFactory"));
                btnComfirmEditFactory.Click();

                try
                {
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("编辑成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【编辑技工厂成功】--通过,用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【编辑技工厂成功】--未通过，，用时：" + (DateTime.Now - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【编辑技工厂成功】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region  删除技工厂

        ///// <summary>
        ///// 点击删除技工厂按钮，弹出提醒框，选择确定
        ///// </summary>
        //public static bool Del_FactoryComfirm(Window appWin, out string msg)
        //{
        //    try
        //    {
        //        var startTime = DateTime.Now;

        //        Random num = new Random();
        //        int i = num.Next(1, 25);//产生1到25的随机数

        //        //点击删除按钮
        //        Button btnDelFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnDelFactory").AndIndex(i));
        //        btnDelFactory.Click();

        //        try
        //        {
        //            //捕捉提醒信息
        //            string error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该技工厂？")).ToString();

        //            //选择确定
        //            Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("1"));
        //            btnTips.Click();

        //            try
        //            {
        //                //捕捉提醒信息
        //                error_info = appWin.Get<Label>(SearchCriteria.ByText("删除成功！")).ToString();

        //                //关闭提醒
        //                btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
        //                btnTips.Click();

        //                msg = "测试【点击删除技工厂按钮，弹出提醒框，选择确定】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
        //                return true;
        //            }
        //            catch
        //            {
        //                msg = "测试【点击删除技工厂按钮，弹出提醒框，选择确定】--未通过，缺少删除成功提醒。用时：" + (DateTime.Now - startTime).TotalSeconds;
        //                return false;
        //            }
        //        }
        //        catch
        //        {
        //            msg = "测试【点击删除技工厂按钮，弹出提醒框，选择确定】--未通过，未询问是否删除技工厂。用时：" + (DateTime.Now - startTime).TotalSeconds;
        //            return false;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        msg = "测试【点击删除技工厂按钮，弹出提醒框，选择确定】--失败，原因：" + e.ToString();
        //        return false;
        //    }
        //}

        ///// <summary>
        ///// 点击删除技工厂按钮，弹出提醒框，选择取消
        ///// </summary>
        //public static bool Del_FactoryCancle(Window appWin, out string msg)
        //{
        //    try
        //    {
        //        var startTime = DateTime.Now;

        //        Random num = new Random();
        //        int i = num.Next(1, 25);//产生1到25的随机数

        //        //点击删除按钮
        //        Button btnDelFactory = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnDelFactory").AndIndex(i));
        //        btnDelFactory.Click();

        //        try
        //        {
        //            //捕捉提醒信息
        //            string error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该技工厂？")).ToString();

        //            //选择取消
        //            Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
        //            btnTips.Click();

        //            try
        //            {
        //                //捕捉提醒信息，此处能捕捉到的话，测试不通过
        //                error_info = appWin.Get<Label>(SearchCriteria.ByText("确定删除该技工厂？")).ToString();

        //                msg = "测试【点击删除技工厂按钮，弹出提醒框，选择取消】--未通过，没有关闭询问框。用时：" + (DateTime.Now - startTime).TotalSeconds;
        //                return false;
        //            }
        //            catch
        //            {
        //                msg = "测试【点击删除技工厂按钮，弹出提醒框，选择取消】--通过，用时：" + (DateTime.Now - startTime).TotalSeconds;
        //                return true;
        //            }
        //        }
        //        catch
        //        {
        //            msg = "测试【点击删除技工厂按钮，弹出提醒框，选择取消】--未通过，未询问是否删除技工厂。用时：" + (DateTime.Now - startTime).TotalSeconds;
        //            return false;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        msg = "测试【点击删除技工厂按钮，弹出提醒框，选择取消】--失败，原因：" + e.ToString();
        //        return false;
        //    }
        //}

        #endregion
    }
}
