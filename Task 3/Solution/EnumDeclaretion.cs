using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class EnumDeclaretion
    {
        public enum Gender : byte { M, F }
        public enum SecurityLevel : byte
        {
            Guest,
            Developer,
            Secertary,
            DBA
        }
    }
}
