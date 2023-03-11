namespace GUIFM
{
    public interface ICommand
    {
        public string CommandText { get; }

        public string CommandKey { get; }

        public List<Parameter> Data { get; set; }

        public List<Parameter> SaveData { get; set; }

        public void Load();
    }
}
