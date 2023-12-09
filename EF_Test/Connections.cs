using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test
{
    internal static class Connections
    {
        public const string sqlConStr = """
               Server=DESKTOP-E0QD2TF\SQL2019;
               Database=dbEfTest;
               User Id=sa;
               Password=123456;
               TrustServerCertificate=True;
            """;
    }
}
