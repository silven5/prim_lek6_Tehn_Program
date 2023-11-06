using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace prim5_lek6.Class
{
    internal class Teacher_list
    {//Список викладачів
        public List<Teacher> people = new List<Teacher>();
        //Серіалізатор для запису у файл
        XmlSerializer serializer = new XmlSerializer(typeof(List<Teacher>));
        public void add(Teacher person)
        {
            people.Add(person);
        }
        public void remove(int i)
        {
            people.RemoveAt(i);
        }
        public void writeFile(string fileName)
        {
            FileStream fstream = new FileStream(fileName, FileMode.Create,
                FileAccess.Write, FileShare.None);
            serializer.Serialize(fstream, people);
            fstream.Close();
        }
        public void readFile(string fileName)
        {
            FileStream fstream = new FileStream(fileName, FileMode.Open,
                FileAccess.Read, FileShare.None);
            people = serializer.Deserialize(fstream) as List<Teacher>;
            fstream.Close();
        }
    }
}
