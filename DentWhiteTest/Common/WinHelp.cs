using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using System.Threading;

namespace DentWhiteTest.Common
{
    public static class WinHelp
    {
        /// <summary>
        /// 启动客户端
        /// </summary>
        /// <param name="appWin">客户端</param>
        /// <param name="msg">测试结果</param>
        /// <param name="path">客户端路径</param>
        /// <param name="name">客户端名称</param>
        /// <param name="id">客户端id</param>
        /// <returns></returns>
        public static bool Launch(out Window appWin, out string msg, string path, string name, string id)
        {
            //启动客户端
            try
            {
                var startTime = DateTime.Now;
                TestStack.White.Application appTest = TestStack.White.Application.Launch(path);
                //Thread.Sleep(300);
                appWin = appTest.GetWindow(SearchCriteria.ByAutomationId(id), InitializeOption.NoCache);
                var endTime = DateTime.Now;
                msg = "启动"+ name + "客户端--通过，用时：" + (endTime - startTime).TotalSeconds;

                //模拟关闭鼠标单击任意点，关闭更新提醒

                return true;
            }
            catch (Exception e)
            {
                appWin = null;
                msg = "启动" + name + "客户端--失败，原因：" + e.ToString();
                return false;
            }
        }
    }
}
