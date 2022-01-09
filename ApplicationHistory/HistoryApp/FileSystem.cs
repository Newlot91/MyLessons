using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HistoryApp
{
    public static class FileSystem
    {
        public static void SaveData(string path, Stack<string> backHistory)//как правильно Stack сделать Serialization? создать свой унаследованный класс от Stack и сериализовать его?
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream($"{path}history.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, backHistory);
            }
        }
        public static void LoadData(string path, ref Stack<string> backHistory)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream($"{path}history.dat", FileMode.OpenOrCreate))
            {
                backHistory = (Stack<string>)formatter.Deserialize(fs);
            }
        }
    }
}
