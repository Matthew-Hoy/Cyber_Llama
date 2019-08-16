using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

public class HashUserInfo
{
    public static string hash(string Text, string salt)
    {
        SHA1 haser = SHA1.Create();
        byte[] hashedBytes = haser.ComputeHash(Encoding.Default.GetBytes(string.Concat(Text,salt)));
        haser.Clear();
        string hashedPassword = "";
        for(int i = 0; i < hashedBytes.Length - 1; i++)
        {
            hashedPassword += hashedBytes[i].ToString("x2");
        }
        return hashedPassword;

    }
}