using Microsoft.Extensions.Configuration;

namespace OdeToFood {
    public interface IGreeter {
        string GetMessageOfTheDa();
    }

    public class Greeter : IGreeter {
        public string GetMessageOfTheDa() {
            return _configuration["Greeting"];
        }
        public Greeter(IConfiguration configuration) => _configuration = configuration;
        private IConfiguration _configuration;
    }
}