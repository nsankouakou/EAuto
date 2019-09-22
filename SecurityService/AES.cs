using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;

namespace SecurityService
{
    public class AES
    {




        public static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            // Create an RijndaelManaged object
            // with the specified key and IV.
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

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

        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
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

            // Create an RijndaelManaged object
            // with the specified key and IV.
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

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


        public static byte[] EncryptWithAes(byte[] plainContent, byte[] key)
        {
            if (plainContent == null || plainContent.Length == 0) { throw new ArgumentNullException("plainText"); }
            if (key == null || key.Length == 0) { throw new ArgumentNullException("key"); }

            byte[] encrypted;
            using (Aes aes = Aes.Create())
            using (SHA256 sha256 = SHA256.Create())
            {
                ICryptoTransform encryptor;
                byte[] signature = sha256.ComputeHash(plainContent);

                aes.GenerateIV();
                aes.Mode = CipherMode.CBC;
                aes.Key = key;
                if (aes.IV == null || aes.IV.Length != 16)
                {
                    throw new Exception("Invalid initialization vector");
                }

                encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    memoryStream.Write(aes.IV, 0, aes.IV.Length);
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.WriteByte(1);
                        cryptoStream.Write(signature, 0, signature.Length);
                        cryptoStream.Write(plainContent, 0, plainContent.Length);
                    }

                    encrypted = memoryStream.ToArray();
                }
            }

            return encrypted;
        }

        public static byte[] DecryptWithAes(byte[] cipherText, byte[] key)
        {
            if (cipherText == null || cipherText.Length == 0) { throw new ArgumentNullException("cipherText"); }
            if (key == null || key.Length == 0) { throw new ArgumentNullException("Key"); }

            byte[] plainContent = null;

            using (SHA256 sha256 = SHA256.Create())
            using (Aes aes = Aes.Create())
            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                byte[] initializationVector = new byte[16];
                ICryptoTransform decryptor;

                msDecrypt.Read(initializationVector, 0, initializationVector.Length);
                aes.Mode = CipherMode.CBC;
                aes.Key = key;
                aes.IV = initializationVector;

                decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream outputDecrypt = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        int hashAlgorithm = cryptoStream.ReadByte();

                        if (hashAlgorithm == 1)
                        {
                            byte[] signature = new byte[32];
                            byte[] computedSignature;

                            cryptoStream.Read(signature, 0, 32);
                            cryptoStream.CopyTo(outputDecrypt);
                            plainContent = outputDecrypt.ToArray();
                            computedSignature = sha256.ComputeHash(plainContent);

                            if (!CompareByteArray(computedSignature, signature))
                            {
                                throw new Exception("Corrupted data");
                            }
                        }
                    }
                }

            }

            return plainContent;
        }

        static bool CompareByteArray(byte[] a1, byte[] a2)
        {
            return StructuralComparisons.StructuralEqualityComparer.Equals(a1, a2);
        }
    }
}
