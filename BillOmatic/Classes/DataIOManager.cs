using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillOmatic.Classes
{
    class DataIOManager
    {
        public static string dir = @"c:\temp";
        public static string serializationFile = Path.Combine(dir, "billList.bin");

        public static void saveBills(List<Bill> billList)
        {
            //serialize
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, billList);
            }
        }

        public static List<Bill> loadBillList()
        {
            //deserialize
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                                
                try
                {
                    return (List<Bill>)bformatter.Deserialize(stream);
                }
                catch
                {
                    return new List<Bill>();
                }
            }
        }

    }
}
