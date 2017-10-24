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
                //输入医院名称
                TextBox txtSearchHospital = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtSearchHospital"));
                txtSearchHospital.BulkText = "口腔";

                //点击查询按钮
                Button btnSearch = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearch"));
                btnSearch.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();

                    btnSearch.Click();

                    error_info = appWin.Get<Label>(SearchCriteria.ByText("查询角色列表异常！")).ToString();

                    msg = "测试【输入医院名称，点击查询按钮，加载该医院】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【输入医院名称，点击查询按钮，加载该医院】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
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

                //医院名称为空
                TextBox txtSearchHospital = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtSearchHospital"));
                txtSearchHospital.Text = "";

                //点击查询按钮
                Button btnSearch = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnSearch"));
                btnSearch.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试未通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("查询医院列表异常！")).ToString();
                    msg = "测试【医院名称为空，点击查询按钮，加载所有医院】--未通过，" + error_info + "用时：" + (endTime - startTime).TotalSeconds;
                    return false;

                }
                catch
                {
                    msg = "测试【医院名称为空，点击查询按钮，加载所有医院】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【医院名称为空，点击查询按钮，加载所有医院】--失败，原因：" + e.ToString();
                return false;
            }
        }

        #endregion

        #region 增加医院
        /// <summary>
        /// 新增医院，医院名称为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        /// 增加按钮：btnAddHospital
        /// 医院名称：txtHospitalName
        /// 选择省：cbProvince
        /// 选择市：cbCity
        /// 选择区：cbDistrict
        /// 详细地址：txtAddress
        /// 医院简介：txtHospitalIntro
        /// 医院负责人：txtHospitalManager
        /// 负责人图片：btnManagerBadgeUpdated
        /// 营业执照：btnCharterUpdated
        /// 执照编号：txtCharterSn
        /// 注册时间：dpRegisterDate
        /// 市场负责人：txtMarketLeader
        /// 确认按钮：btnComfirmAddHospital
        /// 取消按钮：btnCancleAddHospital
        public static bool AddHospital_NameNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddHospital = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddHospital"));
                btnAddHospital.Click();

                //点击确定按钮
                Button btnComfirmAddHospital = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddHospital"));
                btnComfirmAddHospital.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("医院名称不能为空！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医院，医院名称为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医院，医院名称为空】--未通过，缺少医院名称验证提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医院，医院名称为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医院，省份为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddHospital_ProvinceNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //角色名称不为空
                TextBox txtHospitalName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtHospitalName"));
                txtHospitalName.BulkText = "中国国民医院";

                //点击确定按钮
                Button btnComfirmAddHospital = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddHospital"));
                btnComfirmAddHospital.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉报错信息，如果能捕捉到，则测试通过
                    string error_info = appWin.Get<Label>(SearchCriteria.ByText("省不能为空！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医院，省份为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医院，省份为空】--未通过，缺少省份错误提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医院，省份为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医院，市为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddHospital_CityNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //角色名称不为空
                TextBox txtHospitalName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtHospitalName"));
                txtHospitalName.BulkText = Generate.GenerateChineseWords(4);

                //选择省份
                ComboBox cbProvince = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbProvince"));
                cbProvince.Select(2);


                //点击确定按钮
                Button btnComfirmAddHospital = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddHospital"));
                btnComfirmAddHospital.Click();

                var endTime = DateTime.Now;

                try
                {
                    Thread.Sleep(300);
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string succ_info = appWin.Get<Label>(SearchCriteria.ByText("市不能为空！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医院，市为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医院，市为空】--未通过，缺少市错误提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医院，市为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医院，区为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddHospital_DistrictNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //角色名称不为空
                TextBox txtHospitalName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtHospitalName"));
                txtHospitalName.BulkText = Generate.GenerateChineseWords(4);

                //选择省份
                ComboBox cbProvince = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbProvince"));
                cbProvince.Select(18);

                //选择城市
                ComboBox cbCity = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbCity"));
                cbCity.Select(1);


                //点击确定按钮
                Button btnComfirmAddHospital = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddHospital"));
                btnComfirmAddHospital.Click();

                var endTime = DateTime.Now;

                try
                {
                    Thread.Sleep(300);
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string succ_info = appWin.Get<Label>(SearchCriteria.ByText("区不能为空！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医院，区为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医院，区为空】--未通过，缺少区错误提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医院，区为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医院，详细地址为空
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddHospital_DetailNull(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //角色名称不为空
                TextBox txtHospitalName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtHospitalName"));
                txtHospitalName.BulkText = Generate.GenerateChineseWords(4);

                //选择省份
                ComboBox cbProvince = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbProvince"));
                cbProvince.Select(18);

                //选择城市
                ComboBox cbCity = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbCity"));
                cbCity.Select(1);

                //选择区
                ComboBox cbDistrict = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbDistrict"));
                cbDistrict.Select(1);

                //点击确定按钮
                Button btnComfirmAddHospital = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddHospital"));
                btnComfirmAddHospital.Click();

                var endTime = DateTime.Now;

                try
                {
                    Thread.Sleep(300);
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string succ_info = appWin.Get<Label>(SearchCriteria.ByText("详细地址不能为空！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医院，详细地址为空】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医院，详细地址为空】--未通过，缺少详细地址错误提醒。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医院，详细地址为空】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医院，上传图片超过5M
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddHospital_uploadBig(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //角色名称不为空
                TextBox txtHospitalName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtHospitalName"));
                txtHospitalName.BulkText = Generate.GenerateChineseWords(4);

                //选择省份
                ComboBox cbProvince = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbProvince"));
                cbProvince.Select(18);

                //选择城市
                ComboBox cbCity = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbCity"));
                cbCity.Select(1);

                //选择区
                ComboBox cbDistrict = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbDistrict"));
                cbDistrict.Select(1);

                //填写详细地址
                TextBox txtAddress = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtAddress"));
                txtAddress.BulkText = Generate.GenerateChineseWords(6);

                //点击选择工牌照片
                Button btnManagerBadgeUpdated = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<Button>(SearchCriteria.ByAutomationId("btnManagerBadgeUpdated"));
                btnManagerBadgeUpdated.Click();

                //上传图片
                var selectWinA = appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag = selectWinA.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Images\15m.jpg";
                Button btn = selectWinA.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn.Click();


                //点击确定按钮
                Button btnComfirmAddHospital = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddHospital"));
                btnComfirmAddHospital.Click();

                var endTime = DateTime.Now;

                try
                {
                    Thread.Sleep(300);
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string succ_info = appWin.Get<Label>(SearchCriteria.ByText("图片不得大于5M！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    msg = "测试【新增医院，图片大于15m】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;

                }
                catch
                {
                    msg = "测试【新增医院，图片大于15m】--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医院，图片大于15m】--失败，原因：" + e.ToString();
                return false;
            }
        }

        /// <summary>
        /// 新增医院，增加成功
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddHospital_Succ(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //角色名称不为空
                TextBox txtHospitalName = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtHospitalName"));
                txtHospitalName.BulkText = Generate.GenerateChineseWords(4);

                //选择省份
                ComboBox cbProvince = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbProvince"));
                cbProvince.Select(18);

                //选择城市
                ComboBox cbCity = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbCity"));
                cbCity.Select(1);

                //选择区
                ComboBox cbDistrict = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<ComboBox>(SearchCriteria.ByAutomationId("cbDistrict"));
                cbDistrict.Select(1);

                //填写详细地址
                TextBox txtAddress = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtAddress"));
                txtAddress.BulkText = Generate.GenerateChineseWords(6);

                //医院简介
                TextBox txtHospitalIntro = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtHospitalIntro"));
                txtHospitalIntro.BulkText = Generate.GenerateChineseWords(6);

                //医院负责人
                TextBox txtHospitalManager = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtHospitalManager"));
                txtHospitalManager.BulkText = Generate.GenerateChineseWords(6);

                //点击选择工牌照片
                Button btnManagerBadgeUpdated = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<Button>(SearchCriteria.ByAutomationId("btnManagerBadgeUpdated"));
                btnManagerBadgeUpdated.Click();

                //上传图片
                var selectWinA = appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag = selectWinA.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Images\1.jpg";
                Button btn = selectWinA.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn.Click();

                //点击选择营业执照
                Button btnCharterUpdated = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<Button>(SearchCriteria.ByAutomationId("btnCharterUpdated"));
                btnCharterUpdated.Click();

                //上传图片
                var selectWin2 = appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag1 = selectWin2.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag1.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Images\1.jpg";
                Button btn1 = selectWin2.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn1.Click();

                //执照编号
                TextBox txtCharterSn = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtCharterSn"));
                txtCharterSn.Text = "93838383838383838";

                //市场负责人
                TextBox txtMarketLeader = appWin.MdiChild(SearchCriteria.ByAutomationId("AddOrEditHospitalView")).Get<TextBox>(SearchCriteria.ByAutomationId("txtMarketLeader"));
                txtMarketLeader.BulkText = Generate.GenerateChineseWords(3);

                //点击确定按钮
                Button btnComfirmAddHospital = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnComfirmAddHospital"));
                btnComfirmAddHospital.Click();
                var endTime = DateTime.Now;

                try
                {
                    Thread.Sleep(300);
                    //捕捉提醒信息，如果能捕捉到，则测试通过
                    string succ_info = appWin.Get<Label>(SearchCriteria.ByText("新增成功！")).ToString();
                    //关闭提醒框
                    Button btnTips = appWin.Get<Button>(SearchCriteria.ByAutomationId("2"));
                    btnTips.Click();

                    //捕捉新增角色窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增医院")).ToString();

                    msg = "测试【新增医院成功，同时关闭新增医院窗口】--未通过，用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【新增医院成功，同时关闭新增医院窗口】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医院成功，同时关闭新增医院窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }



        /// <summary>
        /// 新增医院，点击取消按钮，关闭新增医院窗口
        /// </summary>
        /// <param name="appWin"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool AddHospital_ClickCancle(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;

                //点击新增按钮
                Button btnAddHospital = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddHospital"));
                btnAddHospital.Click();

                //点击取消按钮
                Button btnCancleAddHospital = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnCancleAddHospital"));
                btnCancleAddHospital.Click();

                var endTime = DateTime.Now;

                try
                {
                    //捕捉新增角色窗口，如果不能捕捉到，则测试通过
                    string add_win = appWin.Get<Label>(SearchCriteria.ByText("新增医院")).ToString();
                    msg = "测试【新增医院，点击取消按钮，关闭新增医院窗口】--未通过，未关闭新增窗口。用时：" + (endTime - startTime).TotalSeconds;
                    return false;
                }
                catch
                {
                    msg = "测试【新增医院，点击取消按钮，关闭新增医院窗口】--通过，用时：" + (endTime - startTime).TotalSeconds;
                    return true;
                }
            }
            catch (Exception e)
            {
                msg = "测试【新增医院，点击取消按钮，关闭新增医院窗口】--失败，原因：" + e.ToString();
                return false;
            }
        }
        #endregion
    }

}
