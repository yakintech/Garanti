namespace DISingletonScopedTransient.Services
{
    public class SingletonService : ISingletonService
    {
        private readonly string _guid;

        public SingletonService()
        {
            _guid = System.Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
