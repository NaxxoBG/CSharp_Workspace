using System;
using System.IO;
using System.Threading;

namespace Reader
{
    class Reader
    {
        string fileName;
        public string data;

        public Reader(string fn)
        {
            fileName = fn;
        }

        public void Read()
        {
            FileStream s = new FileStream(fileName, FileMode.Open);
            StreamReader r = new StreamReader(s);
            data = r.ReadToEnd();
            r.Close();
            s.Close();
        }

        static void Main(string[] args)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fullName1 = Path.Combine(desktopPath, "File1.txt");
            string fullName2 = Path.Combine(desktopPath, "File2.txt");

            Reader reader1 = new Reader(fullName1);
            Reader reader2 = new Reader(fullName2);

            Thread th1 = new Thread(new ThreadStart(reader1.Read));
            Thread th2 = new Thread(new ThreadStart(reader2.Read));

            th1.Start();
            th2.Start();

            th1.Join();
            th2.Join();

            Console.WriteLine(reader1.data.Length == reader2.data.Length ? reader1.data.Equals(reader2.data) : false);
        }
    }
}
