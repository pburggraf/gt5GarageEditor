namespace GT5SaveGameLibrary
{
    public class SaveGame
    {
        private readonly string _savePath;

        public Pddb Pddb { get; set; }
        public SqlLiteDb SqlLiteDb { get; set; }

        public SaveGame(string savePath)
        {
            _savePath = savePath;
            Pddb = new Pddb(savePath);
            SqlLiteDb = new SqlLiteDb(savePath);
        }
    }
}
