using System;
using System.Text;
class Program {
    public static string EncryptDecrypt(string szPlainText, int szEncryptionKey)  
     {  
       StringBuilder szInputStringBuild = new StringBuilder(szPlainText);  
       StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);  
       char Textch;  
       for (int iCount = 0; iCount < szPlainText.Length; iCount++)  
       {  
         Textch = szInputStringBuild[iCount];  
         Textch = (char)(Textch ^ szEncryptionKey);  
         szOutStringBuild.Append(Textch);  
       }  
       return szOutStringBuild.ToString();  
     }  

    static void Main(string[] args) {
        int key = 24312;
        var toEncryptString = "server=localhost;database=library;user=user;password=password";
        var encryptedString = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(EncryptDecrypt(toEncryptString, key)));
        Console.WriteLine(encryptedString);
        Console.WriteLine();
        var decryptedString = EncryptDecrypt(System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(encryptedString)), key);
        Console.WriteLine(decryptedString);
        
    }
}