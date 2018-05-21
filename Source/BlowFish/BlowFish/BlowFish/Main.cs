using System;
using BlowFishCS; 
namespace Main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            short switcher = 0;
            while (switcher != 3)
            {
                Console.WriteLine("1 -- To encrypt text; 2 -- To decrypt text; 3 -- To exit");
                switcher = short.Parse(Console.ReadLine());
                if (switcher == 1)
                {

                    Console.WriteLine(Encrypt());
                }
                else if (switcher == 2)
                {
		    Console.WriteLine(Decrypt());
                }
                else if (switcher == 3)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Unrecognized");
                    Environment.Exit(-1);
                }
            }
            /*Console.WriteLine("Input key (up to 16 char):");
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
            */
        }
        public static  string Encrypt ()
        {
            Console.WriteLine("Input key (up to 28 char):");
	    string key = KeyParse();
            Console.WriteLine("Input string to encrypt:");
            string plainText = Console.ReadLine();
            return b.Encrypt_CBC(plainText);
        }
        public static string Decrypt()
        {
            Console.WriteLine("Input key (up to 28 char):");
            string key = KeyParse();
             Console.WriteLine("Input string to decrypt:");
	     string chipherText = Console.ReadLine();    
            BlowFishCS.BlowFish b = new BlowFish(key);
            return b.Decrypt_CBC(chipherText);
        }
	public static string KeyParse()
	{
	     string key = Console.ReadLine();
	     while (key.Length >= 28 || key.Length == 0)
	     {
		key = Console.ReadLine();     
	     }
	     return key;
	}
    }
}
