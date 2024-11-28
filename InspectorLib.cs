namespace InspectorLib
{
    public class FunctionInsp
    {
        private const string Name = "Автоинспекция г. Чита";
        private string chiefInspector = "Васильев Василий Иванович";
        private List<string> workers = new List<string>
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",
            "Васильев В.И."
        };

        public string GetInspector()
        {
            return chiefInspector;
        }

        public string GetCarInspection()
        {
            return Name;
        }

        public bool SetInspector(string fullname)
        {
            if (workers.Contains(fullname))
            {
                chiefInspector = fullname;
                return true;
            }
            return false;
        }

        public string GenerateNumber(char symbol, int number, int code)
        {
            if (!char.IsUpper(symbol))
                throw new ArgumentException("Symbol must be an uppercase letter.");
            return $"{symbol}{number}_{code}";
        }

        public List<string> GetWorker()
        {
            return workers;
        }

        public void AddWorker(string fullname)
        {
            if (!workers.Contains(fullname))
            {
                workers.Add(fullname);
            }
        }
    }
}
