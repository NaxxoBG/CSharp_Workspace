using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSTest.ServiceReference1;

namespace WSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceReference1.WarehouseWSPortTypeClient cl = new ServiceReference1.WarehouseWSPortTypeClient("ServUtilsHttpSoap12Endpoint");
            //Console.WriteLine(cl.insertPallet(new Pallet()
            //{
            //    count = 14,
            //    goodid = 43,
            //    id = 231
            //}));


            WarehouseWSPortTypeClient client = new WarehouseWSPortTypeClient("WarehouseWSHttpSoap12Endpoint");
            WSTest.ServiceReference1.insertPalletRequest inValue = new WSTest.ServiceReference1.insertPalletRequest();
            inValue.args0 = new Pallet()
            {
                count = 14,
                goodid = 43,
                id = 231
            };
            insertPalletResponse retVal =((WarehouseWSPortType) client).insertPallet(inValue);
            Console.WriteLine(retVal.@return);

           
        }
    }
}
