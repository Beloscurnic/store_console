using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.FactoryMethod2
{
    public  class Uniq_Password
    {
        private string CryptedRandomString()
        {
            lock (this)
            {
                int rand = 0;

                byte[] randomNumber = new byte[5];

                RNGCryptoServiceProvider Gen = new RNGCryptoServiceProvider();
                Gen.GetBytes(randomNumber);

                rand = Math.Abs(BitConverter.ToInt32(randomNumber, 0));

                return ConvertIntToStr(rand);
            }
        }

        private string ConvertIntToStr(int input)
        {
            lock (this)
            {
                string output = "";
                while (input > 0)
                {
                    int current = input % 10;
                    input /= 10;

                    if (current == 0)
                        current = 10;

                    output = (char)((char)'A' + (current - 1)) + output;
                }
                return output;
            }

        }

        public string Vozrat()
        {
            string GeneratedPassword = "";

            GeneratedPassword =CryptedRandomString() + CryptedRandomString();

            return GeneratedPassword;
        }
    }
}
