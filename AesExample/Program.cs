using System;

namespace AesExample
{
    class Program
    {
        private const string ORIGINAL = "this is some data to encrypt";
        private const string SAMPLE_KEY = "gCjK+DZ/GCYbKIGiAt1qCA==";
        private const string SAMPLE_IV = "47l5QsSe1POo31adQ/u7nQ==";

        static void Main(string[] args)
        {            
            //Aes aes = new Aes();    //생성자에 arguments가 없으면 key와 iv 자동생성

            Aes aes = new Aes(SAMPLE_KEY, SAMPLE_IV);

            Console.WriteLine("ORIGINAL:" + ORIGINAL);
            Console.WriteLine("KEY:" + aes.GetKey());
            Console.WriteLine("IV:" + aes.GetIV());

            /*string->byte->string*/
            Console.WriteLine("Example for: string->byte->string");
            byte[] encryptedBlock = aes.EncryptToByte(ORIGINAL);        //original text 를 암호화된 byte 배열로 변환
            string decryptedString = aes.Decrypt(encryptedBlock);       //암호화된 byte 배열을 original text로 복호화
            Console.WriteLine(decryptedString);
            
            /*string->base64->string*/
            Console.WriteLine("Example for: string->base64->string");
            string encryptedBase64String = aes.EncryptToBase64String(ORIGINAL);     //original text를 암호화된 base64 string으로 변환
            decryptedString = aes.DecryptFromBase64String(encryptedBase64String);   //암호호된 base64 string을 original text로 복호화

            Console.WriteLine(encryptedBase64String);
            Console.WriteLine(decryptedString);
            
            
            Console.ReadLine();
        }
    }
}
