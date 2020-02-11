using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LicenseUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path of the folder that contains the license files");
            String sourceFld = Console.ReadLine();

            String[] licensesToUpdate = { @"C:\Users\Naxxo\Desktop\Location2\Subfolder2.1\Subfolder 2.2", @"C:\Users\Naxxo\Desktop\Location2\Subfolder2.1\Subfolder2\AnotherSubfolder\Yet another subfolder" };

            for (int i = 0; i < licensesToUpdate.Length; i++)
            {
                File.Copy(sourceFld, licensesToUpdate[i], true);
            }
        }
    }
}
