using System;

namespace SampleAuthenticator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key;//= args[0];
            //key = "JYD3E2HR5K4P5J5L23U5JXITPM6RJ2AYRP32ZGT7GASFVNET5J7Q"; //AMAZON
            key = "ia2eioedjfposo3l"; //Microsoft

            var bytes = Base32Encoding.ToBytes(key);

            var totp = new Totp(bytes);

            var result = totp.ComputeTotp(8);
            var remainingTime = totp.RemainingSeconds();

            Console.WriteLine(result);
            Console.WriteLine(remainingTime);
            Console.ReadLine();
        }
    }
}