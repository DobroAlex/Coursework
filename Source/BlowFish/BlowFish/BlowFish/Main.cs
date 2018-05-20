using System;
using BlowFishCS; 
namespace Main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input key (up to 16 char):");
            string key = Console.ReadLine();
            if (key.Length>16 || key.Length==0)
            {
                Console.WriteLine("Key is empty or too long");
                Environment.Exit(-1);
            }
            //BlowFish b = new BlowFish("04B915BA43FEB5B6");
            BlowFish b = new BlowFish(key);
            Console.WriteLine("Input line:");
            string plainTxt=Console.ReadLine();
            string chipherTxt = b.Encrypt_CBC(plainTxt);
            Console.WriteLine("chipher text is :" + chipherTxt);
            Console.WriteLine("Decrypted text is: "+ b.Decrypt_CBC(chipherTxt));
        }
    }
}
