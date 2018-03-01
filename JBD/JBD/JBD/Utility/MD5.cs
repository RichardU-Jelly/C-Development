using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace JBD.Utility
{
    class MD5
    {
        /* Method for hashing string via MDP cypher, return hashed string or caught exception */
        public static string CreateMD5(string input)
        {
            try
            {
                using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
                {
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                    }
                    return sb.ToString();
                }
            } catch(Exception caughtEx)
            {
                throw new Exception("Unknown Exception Thrown: "
                       + "\n  Type:    " + caughtEx.GetType().Name
                       + "\n  Message: " + caughtEx.Message);
            }
        }

    }
}
