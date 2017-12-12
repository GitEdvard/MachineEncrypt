using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace MachineEncrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] original, encrypted;

            if (args.GetLength(0) != 1)
            {
                Console.WriteLine("Usage: MachineEncrypt <string to encrypt>");
                return;
            }

            try
            {
                original = Encoding.ASCII.GetBytes(args[0]);
                encrypted = ProtectedData.Protect(original, null, DataProtectionScope.LocalMachine);
                Console.WriteLine(Convert.ToBase64String(encrypted));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during execution: " + ex.Message);
            }
        }
    }
}
