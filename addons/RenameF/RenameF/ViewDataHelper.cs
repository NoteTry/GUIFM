using GUIFM;

namespace RenameF
{
    public static class ViewDataHelper
    {
        public static List<Parameter> Data { get; set; }

        public static Parameter GetData(string name)
        {
            foreach (Parameter SaveData in Data)
            {
                if (SaveData.Name == name)
                    return SaveData;
            }
            return null;
        }
    }
}
