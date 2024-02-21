using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAL_CA2.Classes
{
    [Serializable]
    public static class General
    {
        public static string GenerateUUID()
        {
            // Get global unique indentifier
            Guid uuid = Guid.NewGuid();
            string uuidString = uuid.ToString();

            return uuidString;
        } 
    }
}
