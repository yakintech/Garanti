namespace DISingletonScopedTransient.Services
{
    public class TransientService : ITransientService
    {
        private readonly string _guid;

        public TransientService()
        {
            _guid = System.Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}
