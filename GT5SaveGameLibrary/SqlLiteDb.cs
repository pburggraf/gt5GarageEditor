namespace GT5SaveGameLibrary
{
    public class SqlLiteDb
    {
        private readonly string _savePath;

        public SqlLiteDb(string savePath)
        {
            _savePath = savePath;
        }
    }
}