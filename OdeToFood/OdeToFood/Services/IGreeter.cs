using Microsoft.Extensions.Configuration;

namespace OdeToFood.Services {
    public interface IGreeter {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter {
        public string GetMessageOfTheDay() {
            return _configuration["Greeting"];
        }
        public Greeter(IConfiguration configuration) => _configuration = configuration;
        private IConfiguration _configuration;
    }
}