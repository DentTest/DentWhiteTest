using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentWhiteTest.Helper
{
    public class Generate
    {
        /// <summary>  
        /// 随机产生常用汉字  
        /// </summary>  
        /// <param name="count">要产生汉字的个数</param>  
        /// <returns>常用汉字</returns>  
        public static string GenerateChineseWords(int count)
        {
            string chineseWords = string.Empty;
            Random rm = new Random();
            Encoding gb = Encoding.GetEncoding("gb2312");

            for (int i = 0; i < count; i++)
            {
                // 获取区码(常用汉字的区码范围为16-55)  
                int regionCode = rm.Next(16, 56);
                // 获取位码(位码范围为1-94 由于55区的90,91,92,93,94为空,故将其排除)  
                int positionCode;
                if (regionCode == 55)
                {
                    // 55区排除90,91,92,93,94  
                    positionCode = rm.Next(1, 90);
                }
                else
                {
                    positionCode = rm.Next(1, 95);
                }

                // 转换区位码为机内码  
                int regionCode_Machine = regionCode + 160;// 160即为十六进制的20H+80H=A0H  
                int positionCode_Machine = positionCode + 160;// 160即为十六进制的20H+80H=A0H  

                // 转换为汉字  
                byte[] bytes = new byte[] { (byte)regionCode_Machine, (byte)positionCode_Machine };
                chineseWords = gb.GetString(bytes);
            }
            return chineseWords;
        }

        /// <summary>
        /// 获取随机字符串
        /// </summary>
        /// <param name="strLength">字符串长度</param>
        /// <param name="Seed">随机函数种子值</param>
        /// <returns>指定长度的随机字符串</returns>
        public string GetString(int strLength, params int[] Seed)
        {
            string strSep = ",";
            char[] chrSep = strSep.ToCharArray();
            string strChar = "0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z"
             + ",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            string[] aryChar = strChar.Split(chrSep, strChar.Length);
            string strRandom = string.Empty;
            Random Rnd;
            if (Seed != null && Seed.Length > 0)
            {
                Rnd = new Random(Seed[0]);
            }
            else
            {
                Rnd = new Random();
            }
            //生成随机字符串
            for (int i = 0; i < strLength; i++)
            {
                strRandom += aryChar[Rnd.Next(aryChar.Length)];
            }
            return strRandom;
        }


        private static char[] constant ={ 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        /// <summary>
        /// 随机生产纯字母字符串
        /// </summary>
        /// <param name="Length"></param>
        /// <returns></returns>
        public static string GenerateEnRandom(int Length)
        {
            System.Text.StringBuilder newRandom = new System.Text.StringBuilder(52);
            Random rd = new Random();
            for (int i = 0; i < Length; i++)
            {
                newRandom.Append(constant[rd.Next(52)]);
            }
            return newRandom.ToString();
        }
    }
}
