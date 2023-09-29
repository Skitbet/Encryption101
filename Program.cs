class Program {

    static void Main()
    {

        FileEncryptor encryptor = new FileEncryptor();

        string inputFile = "";
        string encryptedFile = "";
        string decryptedFile = "";

        Console.WriteLine("(1) Encrypt or (2) Decrypt");
        int mode;
        bool validMode = false;

        do
        {
            string? input = Console.ReadLine();
            validMode = int.TryParse(input, out mode);

            if (mode != null && (mode == 1 || mode == 2)) {
                validMode = true;
            }

        } while (validMode == false);

switch (mode)
{
    case 1:
        Console.WriteLine("Enter file to encrypt:");
        string? file;
        do
        {
            file = Console.ReadLine();
        } while (file == null);

        Console.WriteLine("Enter output file:");
        string? outputFile;
        do
        {
            outputFile = Console.ReadLine();
        } while (outputFile == null);

        encryptor.EncryptFile(file, outputFile);
        Console.WriteLine("File encrypted successfully.");
        break;

    case 2:
        Console.WriteLine("Enter file to decrypt:");
        string? decryptFile;
        do
        {
            decryptFile = Console.ReadLine();
        } while (decryptFile == null); // Change the condition to exit when decryptFile is not null

        Console.WriteLine("Enter output file:");
        string? outputDecryptFile;
        do
        {
            outputDecryptFile = Console.ReadLine();
        } while (outputDecryptFile == null); // Change the condition to exit when outputDecryptFile is not null

        encryptor.DecryptFile(decryptFile, outputDecryptFile);
        Console.WriteLine("File decrypted successfully.");
        break;
}

        // // Encrypt the file
        // encryptor.EncryptFile(inputFile, encryptedFile);

        // Console.WriteLine("File encrypted successfully.");

        // // Decrypt the file
        // encryptor.DecryptFile(encryptedFile, decryptedFile);

        // Console.WriteLine("File decrypted successfully.");
    }

}