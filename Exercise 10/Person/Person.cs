using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Person
{
    [Serializable]
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }

        private Person() {}

        public Person(string fname, string lname, int ssn)
        {
            FirstName = fname;
            LastName = lname;
            Ssn = ssn;
        }

        public static void SavePersonToFile(string fname, string lname, int ssn)
        {
            Person person = new Person(fname, lname, ssn);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Person.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, person);
            stream.Close();
        }

        public static Person ReadPersonFromFile()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Person.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Person person = (Person)formatter.Deserialize(stream);
            stream.Close();
            return person;
        }

        public override String ToString()
        {
            return String.Format("First Name: {0}, Last Name {1}, SSN {2}", FirstName, LastName, Ssn);
        }
    }
}
