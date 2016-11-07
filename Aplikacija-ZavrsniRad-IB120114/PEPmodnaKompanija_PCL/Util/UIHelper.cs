using PCLCrypto;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PEPmodnaKompanija_PCL.Util
{
    public class UIHelper
    {

        #region Salt/Hash lozinka

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string lozinka, string salt)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(lozinka);
            byte[] src = Convert.FromBase64String(salt);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            //Izmijenjeno
            var algorithm = WinRTCrypto.HashAlgorithmProvider.OpenAlgorithm(HashAlgorithm.Sha1);
            byte[] inArray = algorithm.HashData(dst);

            return Convert.ToBase64String(inArray);
        }

        #endregion




   }


}
