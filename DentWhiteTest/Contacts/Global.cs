using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;

namespace DentWhiteTest.Contacts
{
    public class Global
    {

        static Global()
        {
            LstInfo = new ObservableCollection<string>();
        }
        /// <summary>
        /// 测试结果信息列表
        /// </summary>
        public static ObservableCollection<string> LstInfo { get; set; }

        public static Window win_Dent { get; set; }
    }
}
