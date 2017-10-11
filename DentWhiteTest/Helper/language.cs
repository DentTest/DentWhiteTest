using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhiteFrameDemo.TestCase
{
    public class Language
    {
        static InputLanguage en { get; set; }
        static InputLanguage zh { get; set; }


        //[DllImport("imm32.dll")]
        //static extern IntPtr ImmGetContext(IntPtr hWnd);

        //[DllImport("imm32.dll")]
        //static extern bool ImmSetConversionStatus(IntPtr hIMC, int conversion, int sentence);


        public Language()
        {
            foreach (InputLanguage inputLanguage in InputLanguage.InstalledInputLanguages)
            {
                if (inputLanguage.Culture.Name

.                   IndexOf("en") >= 0)
                {
                    en = inputLanguage;
                }
                if (inputLanguage.Culture.Name.IndexOf("zh") >= 0)
                {
                    zh = inputLanguage;
                }
            }
        }


        public static void Set(string language)
        {
            switch (language)
            {
                case "en":
                    InputLanguage.CurrentInputLanguage = en;
                    break;
                case "zh":
                    InputLanguage.CurrentInputLanguage = zh;
                    //IntPtr Hime = ImmGetContext(zh.Handle);
                    //int iMode = 0;
                    //int iSentence = 0;
                    //var b = ImmSetConversionStatus(Hime, iMode, iSentence);//中文半角

                    break;
                default: break;
            }
        }
    }
}
