namespace DISingletonScopedTransient.Services
{
    public class ScopedService : IScopedService
    {
        private readonly string _guid;

        public ScopedService()
        {
            _guid = System.Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
