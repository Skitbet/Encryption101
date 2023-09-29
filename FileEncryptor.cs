using System;
using System.IO;

class FileEncryptor {
    public void EncryptFile(string inputFile, string outputFile)
    {
        int key = 3;

        using (StreamReader reader = new StreamReader(inputFile))
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            while (!reader.EndOfStream)
            {
                int currentChar = reader.Read();
                if (currentChar != -1)
                {
                    char encryptedChar = (char)(currentChar + key);
                    writer.Write(encryptedChar);
                }
            }
        }
    }

    public void DecryptFile(string inputFile, string outputFile)
    {
        int key = -3;

        using (StreamReader reader = new StreamReader(inputFile))
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            while (!reader.EndOfStream)
            {
                int currentChar = reader.Read();
                if (currentChar != -1)
                {
                    char decryptedChar = (char)(currentChar + key);
                    writer.Write(decryptedChar);
                }
            }
        }
    }
}