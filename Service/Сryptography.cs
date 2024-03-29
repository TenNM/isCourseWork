﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace isCourseWork
{
    static class Сryptography
    {
        static private readonly byte[] baseKey = {
                0xFF, 0xAA, 0xFF, 0xAA, 0xFF, 0xAA, 0xFF, 0xAA,
                0xFF, 0xAA, 0xFF, 0xAA, 0xFF, 0xAA, 0xFF, 0xAA,
                0xFF, 0xAA, 0xFF, 0xAA, 0xFF, 0xAA, 0xFF, 0xAA,
                0xFF, 0xAA, 0xFF, 0xAA, 0xFF, 0xAA, 0xFF, 0xAA,
            };
        static private readonly byte[] baseIV = {
                0xF0, 0xA0, 0xF0, 0xA0, 0xF0, 0xA0, 0xF0, 0xA0,
                0xFF, 0xAA, 0xFF, 0xAA, 0xFF, 0xAA, 0xFF, 0xAA,
            };
        static private readonly string SALT = "jkpd1bTU25O4Dg784jkxL94G2bncmk5p0";
        static private readonly string TRASH = "fgdjklsDIK4785nfggfDGCHLHhfzai4M5";
        //----------------------------------------------------------------------------
        internal static byte[] PassToByte16Arr(string pass)
        {
            if (null == pass || 0 == pass.Length) return baseIV;
            for(int i = 0; pass.Length < 16; i++)
            {
                pass += baseIV[i];
            }
            pass = pass.Substring(0, 16);
            return Encoding.ASCII.GetBytes(pass);
        }
        //-------------------------------------------------------------
        internal static string GetRandomTrash()
        {
            long secUnix = DateTimeOffset.UtcNow.ToUnixTimeSeconds();//10 chars
            Random rand = new Random();
            int start = rand.Next(0, 3);
            int length = rand.Next(13, 23);

            return (
                secUnix.ToString() + 
                TRASH.GetHashCode().ToString() + 
                (secUnix+33).ToString()
                ).Substring(start, length);
        }
        //------------------------------------------------------------------------------
        internal static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }
        internal static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
        //---
        internal static byte[] EncryptStringToBytes_Aes(string plainText, byte[] IV)
        {
            return EncryptStringToBytes_Aes(plainText, baseKey, IV);
        }
        internal static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] IV)
        {
            return DecryptStringFromBytes_Aes(cipherText, baseKey, IV);
        }
        //---
        internal static byte[] EncryptStringToBytes_Aes(string plainText)
        {
            return EncryptStringToBytes_Aes(plainText, baseKey, baseIV);
        }
        internal static string DecryptStringFromBytes_Aes(byte[] cipherText)
        {
            return DecryptStringFromBytes_Aes(cipherText, baseKey, baseIV);
        }
        //---------------------------------------------------------------------------
        internal static byte[] GetSha512(string inputStr)
        {
            inputStr = SALT + inputStr + SALT;
            SHA512 shaM = new SHA512Managed();
            byte[] data = Encoding.UTF8.GetBytes(inputStr);
            return shaM.ComputeHash(data);
        }
        //-----------------------------------------------------------------------------
    }
}
