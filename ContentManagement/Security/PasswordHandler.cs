using ContentManagement.Data;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Azure.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ContentManagement.Security
{
    public class PasswordHandler
    {
        public readonly CMSDbContext context;
        private const int SaltSize = 16;
        private const int HashSize = 20;

        public PasswordHandler(CMSDbContext context)
        {
            this.context = context;
        }
        public static string HashPassword(string password)
        {
            // Create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

           // Create the Rfc2898DeriveBytes and get the hash value:
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            // combind hash and salt value 
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            //Turn the combined salt+hash into a string for storage
            return Convert.ToBase64String(hashBytes).ToString(); 


        }
        
        public static bool Verify(string password, string hashedPassword)
        {
            /* Extract the bytes */
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);
            /* Get the salt */
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            /* Compute the hash on the password the user entered */
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            /* Compare the results */
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    return false;

            return true;

        }

    }
}
