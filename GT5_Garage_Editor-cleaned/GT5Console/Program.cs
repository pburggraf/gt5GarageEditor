using GT5SaveGameLibrary;

namespace GT5Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var savePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\_svg";
            var dbPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\_db";
            var save = new SaveGame(savePath);
        }
    }
}
