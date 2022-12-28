using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptchaClass
{
    public class CaptchaC
    {
        public string Value { get; set; }
        public uint SymbolsCount { get; set; }
        public uint DigitsCount { get; set; }
        public bool Repeat { get; set; }

        public CaptchaC(uint SymbolsCount, uint DigitsCount, bool Repeat)
        {
            //if (DigitsCount > SymbolsCount) throw new Exception("Количество чисел больше числа символов");

            this.SymbolsCount = SymbolsCount;
            this.DigitsCount = DigitsCount;
            this.Repeat = Repeat;
        }
        public void Generate()
        {
            string password = "";
            Random rnd = new Random();
            for (int i = 0; i < DigitsCount; i++)
            {
                int a = rnd.Next(0, 2);
                if (a == 0)
                    password += Convert.ToChar(rnd.Next(65, 90));
                else
                    password += Convert.ToChar(rnd.Next(97, 122));
            }
                Value = password;
/*        {
            List<char> chars = new List<char>("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
            char[] captcha = new char[SymbolsCount];
            int used = 0;
            Random r = new Random();
            for (int i = 0; i < SymbolsCount; i++)
            {
                if (DigitsCount < used && Convert.ToBoolean(r.Next(0, 1)))
                {
                    captcha[i] = Convert.ToChar(r.Next(0, 9));
                    used++;
                }
                else
                {
                    captcha[i] = chars[r.Next(0, chars.Count)];
                    if (!Repeat) chars.Remove(captcha[i]);
                }
            }
            Value = String.Join("", chars);
        }
        public bool Compare(string captcha)
        {
            return captcha == Value;
        }*/
        }
    }
}
