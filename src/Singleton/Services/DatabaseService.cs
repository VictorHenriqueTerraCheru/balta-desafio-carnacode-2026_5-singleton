using Models;

namespace Services
{
    // Serviços da aplicação que precisam das configurações
    public class DatabaseService
    {
        private readonly ConfigurationManager _config;

        public DatabaseService() => _config = ConfigurationManager.Instance;

        public void Connect()
        {
            var connectionString = _config.GetSetting("DatabaseConnection");
            Console.WriteLine($"[DatabaseService] Conectando ao banco: {connectionString}");
        }
    }
}