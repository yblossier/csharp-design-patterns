namespace PatternSingleton.Pattern
{
    public class UniqueInstance
    {
        private static UniqueInstance? _instance;

        private readonly string _name;

        private UniqueInstance(string name)
        {
            _name = name;
        }

        public static UniqueInstance? Instance(string name)
        {
            return _instance ??= new UniqueInstance(name);
        }

        public string GetName()
        {
            return _name;
        }
    }
}
