using DentWhiteTest.Common;
using DentWhiteTest.Contacts;
using DentWhiteTest.TestCase;
using DentWhiteTest.TestCase.Docker;
using TestStack.White.UIItems.WindowItems;
using WhiteFrameDemo.TestCase;



namespace DentWhiteTest.Module.Denture
{
    public class FactoryModule
    {
        public static void FactoryAllTest()
        {
            Global.LstInfo.Add("--- 技工厂管理模块 ---");

            //启动一个客户端
            bool res_Launch = WinHelp.Launch(out Window appWin, out string msg, Const.DenturePath, Const.DentName, Const.DentureId);
            Global.LstInfo.Add(msg);
            if (res_Launch)
            {
                Global.Win_Denture = appWin;

                //启动成功，登录
                var _login = LoginDentureTest.LoginDenture_Success(Global.Win_Denture, out string msg_login);
                Global.LstInfo.Add(msg_login);
                //如果登录失败，返回
                if (!_login) return;
            }
            else
            {
                return;
            }

            #region 技工厂列表

            //点击技工厂管理菜单，加载所有技工厂
            res_Launch = FactoryTest.Load_FactoryList(Global.Win_Denture, out string msg1);
            Global.LstInfo.Add(msg1);
            if (!res_Launch) return;

            //输入技工厂名称，点击查询按钮，加载该技工厂
            res_Launch = FactoryTest.Search_FactoryName(Global.Win_Denture, out string msg2);
            Global.LstInfo.Add(msg2);
            if (!res_Launch) return;

            //技工厂名称为空，点击查询按钮，加载所有技工厂
            res_Launch = FactoryTest.Search_FactoryNameNull(Global.Win_Denture, out string msg3);
            Global.LstInfo.Add(msg3);
            if (!res_Launch) return;

            #endregion

            #region 新增技工厂

            //新增技工厂，工厂名称为空
            res_Launch = FactoryTest.AddFactory_FactoryNameBull(Global.Win_Denture, out string msg4);
            Global.LstInfo.Add(msg4);
            if (!res_Launch) return;

            //新增技工厂，工厂名称多于50个字
            res_Launch = FactoryTest.AddFactory_FactoryNameLength(Global.Win_Denture, out string msg12);
            Global.LstInfo.Add(msg12);
            if (!res_Launch) return;


            //新增技工厂，地址为空
            res_Launch = FactoryTest.AddFactory_AddressNull(Global.Win_Denture, out string msg6);
            Global.LstInfo.Add(msg6);
            if (!res_Launch) return;

            //新增技工厂，地址多于150个字
            res_Launch = FactoryTest.AddFactory_AddressLength(Global.Win_Denture, out string msg25);
            Global.LstInfo.Add(msg25);
            if (!res_Launch) return;

            //新增技工厂，电话为空
            res_Launch = FactoryTest.AddFactory_PhoneNull(Global.Win_Denture, out string msg26);
            Global.LstInfo.Add(msg26);
            if (!res_Launch) return;

            //新增技工厂，负责人为空
            res_Launch = FactoryTest.AddFactory_ManagerNull(Global.Win_Denture, out string msg27);
            Global.LstInfo.Add(msg27);
            if (!res_Launch) return;

            //新增技工厂成功，同时关闭新增技工厂窗口
            res_Launch = FactoryTest.AddFactorySucc(Global.Win_Denture, out string msg8);
            Global.LstInfo.Add(msg8);
            if (!res_Launch) return;

            //新增技工厂，点击取消按钮，关闭新增技工厂窗口
            res_Launch = FactoryTest.AddFactory_ClickCancle(Global.Win_Denture, out string msg9);
            Global.LstInfo.Add(msg9);
            if (!res_Launch) return;

            #endregion

            #region 编辑角色

            //编辑技工厂，无修改操作，点击确定按钮
            res_Launch = FactoryTest.EditFactory_NoEdit(Global.Win_Denture, out string msg22);
            Global.LstInfo.Add(msg22);
            if (!res_Launch) return;

            //编辑技工厂，点击取消按钮，关闭编辑技工厂窗口
            res_Launch = FactoryTest.EditFactory_ClickCancle(Global.Win_Denture, out string msg21);
            Global.LstInfo.Add(msg21);
            if (!res_Launch) return;

            //编辑技工厂，工厂名称为空
            res_Launch = FactoryTest.EditFactory_FactoryNameBull(Global.Win_Denture, out string msg28);
            Global.LstInfo.Add(msg28);
            if (!res_Launch) return;

            //编辑技工厂，工厂名称多于50个字
            res_Launch = FactoryTest.EditFactory_FactoryNameLength(Global.Win_Denture, out string msg29);
            Global.LstInfo.Add(msg29);
            if (!res_Launch) return;


            //编辑技工厂，地址为空
            res_Launch = FactoryTest.EditFactory_AddressNull(Global.Win_Denture, out string msg30);
            Global.LstInfo.Add(msg30);
            if (!res_Launch) return;

            //编辑技工厂，地址多于150个字
            res_Launch = FactoryTest.EditFactory_EditressLength(Global.Win_Denture, out string msg31);
            Global.LstInfo.Add(msg31);
            if (!res_Launch) return;

            //编辑技工厂，电话为空
            res_Launch = FactoryTest.EditFactory_PhoneNull(Global.Win_Denture, out string msg32);
            Global.LstInfo.Add(msg32);
            if (!res_Launch) return;

            //编辑技工厂，负责人为空
            res_Launch = FactoryTest.EditFactory_ManagerNull(Global.Win_Denture, out string msg33);
            Global.LstInfo.Add(msg33);
            if (!res_Launch) return;

            //编辑技工厂成功
            res_Launch = FactoryTest.EditFactory_Succ(Global.Win_Denture, out string msg34);
            Global.LstInfo.Add(msg34);
            if (!res_Launch) return;

            #endregion

            #region 删除技工厂

            ////点击删除技工厂按钮，弹出提醒框，选择确定
            //res_Launch = FactoryTest.Del_FactoryComfirm(Global.Win_Denture, out string msg23);
            //Global.LstInfo.Add(msg23);
            //if (!res_Launch) return;

            ////点击删除技工厂按钮，弹出提醒框，选择取消
            //res_Launch = FactoryTest.Del_FactoryCancle(Global.Win_Denture, out string msg24);
            //Global.LstInfo.Add(msg24);
            //if (!res_Launch) return;

            #endregion

            //关闭客户端
            Global.Win_Denture.Close();
        }
    }
}
