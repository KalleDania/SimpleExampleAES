using System;

namespace AesExample
{
    class Program
    {
        private const string ORIGINAL = "Dette er en krypterings test";
        private const string SAMPLE_KEY = "gCjK+DZ/GCYbKIGiAt1qCA==";
        private const string SAMPLE_IV = "47l5QsSe1POo31adQ/u7nQ==";

        static void Main(string[] args)
        {            
            Aes aes = new Aes(SAMPLE_KEY, SAMPLE_IV);

            Console.WriteLine("ORIGINAL:" + ORIGINAL);
            Console.WriteLine("KEY:" + aes.GetKey());
            Console.WriteLine("IV:" + aes.GetIV());

            Console.WriteLine("Example for: string->byte->string");
            byte[] encryptedBlock = aes.EncryptToByte(ORIGINAL);        
            string decryptedString = aes.Decrypt(encryptedBlock);       
            Console.WriteLine(decryptedString);
            

            Console.WriteLine("Example for: string->base64->string");
            string encryptedBase64String = aes.EncryptToBase64String(ORIGINAL);     
            decryptedString = aes.DecryptFromBase64String(encryptedBase64String);   

            Console.WriteLine(encryptedBase64String);
            Console.WriteLine(decryptedString);
            
            
            Console.ReadLine();
        }
    }
}
