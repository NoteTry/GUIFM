namespace GUIFM
{
    public abstract class Command
    {
        public List<Parameter> Data { get; set; }

        public List<Parameter> SaveData { get; set; }

        public Command() 
        {
            SaveData = new List<Parameter>();
        }

        public Parameter GetData(string name)
        {
            return this.Data.Find(x => x.Name == name);
        }

        public Parameter GetSaveData(string name)
        {
            foreach (Parameter SaveData in this.SaveData)
            {
                if (SaveData.Name == name)
                    return SaveData;
            }
            return null;
        }

        public void AddSaveData(string name, string data)
        {
            if (this.SaveData.Exists(x => x.Name == name))
            {
                this.SaveData.FindAll(s => s.Name == name).ForEach(x => x.Value = data);
                return;
            }

            SaveData.Add(new Parameter(name, data));
        }
    }
}
