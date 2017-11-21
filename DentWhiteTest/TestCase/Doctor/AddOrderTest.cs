using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.ListBoxItems;
using DentWhiteTest.Helper;
using System;
using TestStack.White.InputDevices;
using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;

namespace DentWhiteTest.TestCase.DoctorClient
{
    public class AddOrderTest
    {
        private static UITestControl uIItemCustom;
        #region 医生新增订单
        /// <summary>
        /// 点击新增订单，直接提交
        /// </summary>
        public static bool AddOrder_Succ(Window appWin, out string msg)
        {
            try
            {
                var startTime = DateTime.Now;
                //在菜单页点击新增订单
                Button tlOpenAddOrderModule = appWin.Get<Button>(SearchCriteria.ByAutomationId("tlOpenAddOrderModule"));
                tlOpenAddOrderModule.Click();

                //输入姓名
                TextBox txtCustomerRealname = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtCustomerRealname"));
                txtCustomerRealname.BulkText = Generate.GenerateChineseWords(3);

                //选择性别
                RadioButton rbSexGirl = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbSexGirl"));
                rbSexGirl.Click();

                //填写年龄：txtCustomerAge
                TextBox txtCustomerAge = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtCustomerAge"));
                txtCustomerAge.Text = "23";

                //身份证：txtCustomerPin
                TextBox txtCustomerPin = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtCustomerPin"));
                txtCustomerPin.Text = "4400229988776655";
                //手机：txtTelphone
                TextBox txtTelphone = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtTelphone"));
                txtTelphone.Text = "15500000001";
                //主诉：txtContent
                TextBox txtContent = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtContent"));
                txtContent.BulkText = Generate.GenerateChineseWords(10);
                //固定矫治经验：rbFixedExpYes
                RadioButton rbFixedExpYes = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbFixedExpYes"));
                rbFixedExpYes.Click();
                //是否沟通：rbCommunicateYes
                RadioButton rbCommunicateYes = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbCommunicateYes"));
                rbCommunicateYes.Click();
                //检查情况：
                //中线位置上颌：rbMidposUpperCentre
                RadioButton rbMidposUpperCentre = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbMidposUpperCentre"));
                rbMidposUpperCentre.Click();
                //中线位置上颌偏离：txtMidposUpperAway
                TextBox txtMidposUpperAway = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtMidposUpperAway"));
                txtMidposUpperAway.Text = "2";
                //中线位置上颌：rbMidposBelowCentre
                RadioButton rbMidposBelowCentre = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbMidposBelowCentre"));
                rbMidposBelowCentre.Click();
                //中线位置下颌偏离：txtMidposBelowAway
                TextBox txtMidposBelowAway = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtMidposBelowAway"));
                txtMidposBelowAway.Text = "2";
                //前牙覆颌：txtFrontToothCover
                TextBox txtFrontToothCover = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtFrontToothCover"));
                txtFrontToothCover.Text = "2";
                //前牙覆盖：txtAnteriorToothCover
                TextBox txtAnteriorToothCover = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtAnteriorToothCover"));
                txtAnteriorToothCover.Text = "2";
                //磨牙关系右侧：rbMolarRightRecent
                RadioButton rbMolarRightRecent = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbMolarRightRecent"));
                rbMolarRightRecent.Click();
                //磨牙关系左侧：rbMolarLeftNeutral
                RadioButton rbMolarLeftNeutral = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbMolarLeftNeutral"));
                rbMolarLeftNeutral.Click();
                //尖牙关系右侧：rbCanineRightNeutral
                RadioButton rbCanineRightNeutral = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbCanineRightNeutral"));
                rbCanineRightNeutral.Click();
                //尖牙关系左侧：rbCanineLeftRecent
                RadioButton rbCanineLeftRecent = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbCanineLeftRecent"));
                rbCanineLeftRecent.Click();
                //面型：rbFaceTypeConvex
                RadioButton rbFaceTypeConvex = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbFaceTypeConvex"));
                rbFaceTypeConvex.Click();
                //修复体情况：txtRepairBody
                TextBox txtRepairBody = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtRepairBody"));
                txtRepairBody.Text = "2";
                //矫治计划
                //矫治目标：txtTreatmentGoal
                TextBox txtTreatmentGoal = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtTreatmentGoal"));
                txtTreatmentGoal.Text = "2";
                //拟矫治牙列：rbDentitionOn
                RadioButton rbDentitionOn = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbDentitionOn"));
                rbDentitionOn.Click();
                //磨牙保持原有尖牙关系：rbMolarKeepRight
                RadioButton rbMolarKeepRight = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbMolarKeepRight"));
                rbMolarKeepRight.Click();
                //磨牙调整磨牙关系至右侧：rbMolarAdjustRightFar
                RadioButton rbMolarAdjustRightFar = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbMolarAdjustRightFar"));
                rbMolarAdjustRightFar.Click();
                //磨牙调整磨牙关系至左侧：rbMolarAdjustLeftFar
                RadioButton rbMolarAdjustLeftFar = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbMolarAdjustLeftFar"));
                rbMolarAdjustLeftFar.Click();
                //尖牙保持原有尖牙关系：rbCanineKeepLeft
                RadioButton rbCanineKeepLeft = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbCanineKeepLeft"));
                rbCanineKeepLeft.Click();
                //尖牙调整磨牙关系至右侧：rbCanineAdjustRightFar
                RadioButton rbCanineAdjustRightFar = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbCanineAdjustRightFar"));
                rbCanineAdjustRightFar.Click();
                //尖牙调整磨牙关系至左侧：rbCanineAdjustLeftFar
                RadioButton rbCanineAdjustLeftFar = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbCanineAdjustLeftFar"));
                rbCanineAdjustLeftFar.Click();
                //覆颌：rbMalocclusionOn
                RadioButton rbMalocclusionOn = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbMalocclusionOn"));
                rbMalocclusionOn.Click();
                //覆盖：rbCoverKeep
                RadioButton rbCoverKeep = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbCoverKeep"));
                rbCoverKeep.Click();
                //间隙处理：rbGapCloseAll
                RadioButton rbGapCloseAll = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbGapCloseAll"));
                rbGapCloseAll.Click();
                //间隙保留：txtGapRemain
                TextBox txtGapRemain = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtGapRemain"));
                txtGapRemain.Text = "2";
                //后牙锁颌：rbTeethLockKeep
                RadioButton rbTeethLockKeep = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbTeethLockKeep"));
                rbTeethLockKeep.Click();
                //中线关系：rbCenterLineKeep
                RadioButton rbCenterLineKeep = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbCenterLineKeep"));
                rbCenterLineKeep.Click();
                //spee曲线：rbSpeeCurveImprove
                RadioButton rbSpeeCurveImprove = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbSpeeCurveImprove"));
                rbSpeeCurveImprove.Click();
                //同意领面去釉：rbFaceToGlazeNo
                RadioButton rbFaceToGlazeNo = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbFaceToGlazeNo"));
                rbFaceToGlazeNo.Click();
                //同意领面去釉医生建议：txtFaceToGlazeTeeth
                TextBox txtFaceToGlazeTeeth = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtFaceToGlazeTeeth"));
                txtFaceToGlazeTeeth.Text = "2";
                //同意拔牙矫治：rbExtractionYes
                RadioButton rbExtractionYes = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbExtractionYes"));
                rbExtractionYes.Click();
                //同意拔牙矫治医生建议：txtExtractionTeeth
                TextBox txtExtractionTeeth = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtExtractionTeeth"));
                txtExtractionTeeth.Text = "2";
                //过矫正：rbOverCorrectionYes
                RadioButton rbOverCorrectionYes = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbOverCorrectionYes"));
                rbOverCorrectionYes.Click();
                //过矫正医生建议：txtOverCorrectionTeeth
                TextBox txtOverCorrectionTeeth = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtOverCorrectionTeeth"));
                txtOverCorrectionTeeth.Text = "2";
                //面型：rbPlanFaceTypeKeep
                RadioButton rbPlanFaceTypeKeep = appWin.Get<RadioButton>(SearchCriteria.ByAutomationId("rbPlanFaceTypeKeep"));
                rbPlanFaceTypeKeep.Click();
                //特殊要求：txtSpecialDemands
                TextBox txtSpecialDemands = appWin.Get<TextBox>(SearchCriteria.ByAutomationId("txtSpecialDemands"));
                txtSpecialDemands.Text = "2";

                //附件资料：
                //上传1：hgFrontViewPic  ImageLoadingControl  UIA_CustomControlTypeId
                // Image hgFrontViewPic = appWin.Get<Image>(SearchCriteria.ByAutomationId("hgFrontViewPic"));
                //hgFrontViewPic.Click();
                //TextBox text = appWin.Get<TextBox>();
                //Mouse.Click(uIItemCustom, new Point(165, 85));
                //var item = appWin.Get<Image>(SearchCriteria.ByAutomationId("hgFrontViewPic"));
                //Image imageShow = item.<Image>(SearchCriteria.ByAutomationId("imageShow")).;
                //imageShow.Click();x:377 y:869
                appWin.Mouse.Click(new System.Windows.Point(377, 869));
                //上传图片
                var selectWin1 = appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag1 = selectWin1.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag1.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Resourse\Images\3.jpg";
                Button btn1 = selectWin1.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn1.Click();
                //上传2：hgFrontCoverPic
                Button hgFrontCoverPic = appWin.Get<Button>(SearchCriteria.ByAutomationId("hgFrontCoverPic"));
                hgFrontCoverPic.Click();
                //Mouse.Click(uIItemCustom1, new Point(177, 250));
                //上传图片
                var selectWin2 = appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag2 = selectWin2.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag2.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Resourse\Images\3.jpg";
                Button btn2 = selectWin2.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn2.Click();

                //上传3：hgLeftInsidePic
                Button hgLeftInsidePic = appWin.Get<Button>(SearchCriteria.ByAutomationId("hgLeftInsidePic"));
                hgLeftInsidePic.Click();
                //Mouse.Click(uIItemCustom2, new Point(215, 218));
                //Mouse.Click(uIItemCustom3, new Point(185, 86));
                //Mouse.Click(uIItemCustom4, new Point(144, 57));
                //Mouse.Click(uIItemCustom5, new Point(189, 79));
                //Mouse.Click(uIItemCustom6, new Point(151, 244));
                //Mouse.Click(uIItemCustom7, new Point(191, 265));
                //Mouse.Click(uIItemCustom8, new Point(115, 267));
                //Mouse.Click(uIItemCustom9, new Point(173, 220));
                //Mouse.Click(uIItemCustom10, new Point(223, 263));
                //上传图片
                var selectWin3= appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag3 = selectWin3.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag3.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Resourse\Images\3.jpg";
                Button btn3 = selectWin3.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn3.Click();

                //上传4：hgRightInsidePic
                Button hgRightInsidePic = appWin.Get<Button>(SearchCriteria.ByAutomationId("hgRightInsidePic"));
                hgRightInsidePic.Click();
                //上传图片
                var selectWin4 = appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag4 = selectWin4.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag4.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Resourse\Images\3.jpg";
                Button btn4 = selectWin4.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn4.Click();

                //上传5：hgTopInsidePic
                Button hgTopInsidePic = appWin.Get<Button>(SearchCriteria.ByAutomationId("hgTopInsidePic"));
                hgTopInsidePic.Click();
                //上传图片
                var selectWin5 = appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag5 = selectWin5.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag5.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Resourse\Images\3.jpg";
                Button btn5 = selectWin5.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn5.Click();

                //上传6：hgBottomInsidePic
                Button hgBottomInsidePic = appWin.Get<Button>(SearchCriteria.ByAutomationId("hgBottomInsidePic"));
                hgBottomInsidePic.Click();
                //上传图片
                var selectWin6 = appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag6 = selectWin6.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag6.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Resourse\Images\3.jpg";
                Button btn6 = selectWin6.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn6.Click();

                //上传7：hgOutInsidePic
                Button hgOutInsidePic = appWin.Get<Button>(SearchCriteria.ByAutomationId("hgOutInsidePic"));
                hgOutInsidePic.Click();
                //上传图片
                var selectWin7 = appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag7 = selectWin7.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag7.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Resourse\Images\3.jpg";
                Button btn7 = selectWin7.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn7.Click();

                //上传8：hgFrontOutsideSmile
                Button hgFrontOutsideSmile = appWin.Get<Button>(SearchCriteria.ByAutomationId("hgFrontOutsideSmile"));
                hgFrontOutsideSmile.Click();
                //上传图片
                var selectWin8 = appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag8 = selectWin8.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag8.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Resourse\Images\3.jpg";
                Button btn8 = selectWin8.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn8.Click();

                //上传9：hgRightOutsidePic
                Button hgRightOutsidePic = appWin.Get<Button>(SearchCriteria.ByAutomationId("hgRightOutsidePic"));
                hgRightOutsidePic.Click();
                //上传图片
                var selectWin11 = appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag11= selectWin11.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag11.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Resourse\Images\3.jpg";
                Button btn11 = selectWin11.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn11.Click();

                //上传10：hgFullMouthSurface
                Button hgFullMouthSurface = appWin.Get<Button>(SearchCriteria.ByAutomationId("hgFullMouthSurface"));
                hgFullMouthSurface.Click();
                //上传图片
                var selectWin12 = appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag12 = selectWin12.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag12.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Resourse\Images\3.jpg";
                Button btn12 = selectWin12.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn12.Click();

                //上传11：hgLateralProjection
                Button hgLateralProjection = appWin.Get<Button>(SearchCriteria.ByAutomationId("hgLateralProjection"));
                hgLateralProjection.Click();
                //上传图片
                var selectWin13 = appWin.MdiChild(SearchCriteria.ByText("选择文件"));
                TextBox tbImag13 = selectWin13.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
                tbImag13.BulkText = AppDomain.CurrentDomain.BaseDirectory + @"Resourse\Images\3.jpg";
                Button btn13 = selectWin13.Get<Button>(SearchCriteria.ByAutomationId("1"));
                btn13.Click();

                //提交订单 btnAddOrder
                Button btnAddOrder = appWin.Get<Button>(SearchCriteria.ByAutomationId("btnAddOrder"));
                btnAddOrder.Click();

                var endTime = DateTime.Now;

                msg = "测试【点击新增订单菜单】--通过，用时：" + (endTime - startTime).TotalSeconds;
                return true;
            }
            catch (Exception e)
            {
                msg = "测试【点击新增订单菜单】--失败，原因：" + e.Message ;
                return true;
            }
            #endregion
        }
    }
}
