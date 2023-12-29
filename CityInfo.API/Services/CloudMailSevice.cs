namespace CityInfo.API.Services
{
    public class CloudMailSevice : IMailService
    {
        private readonly string _emailTo = string.Empty;
        private readonly string _emailFrom = string.Empty;

        public CloudMailSevice(IConfiguration configuration)
        {
            _emailTo = configuration["mailSettings:mailToAddress"];
            _emailFrom = configuration["mailSettings:mailFromAddress"];
        }

        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from {_emailFrom} to {_emailTo}, with {nameof(CloudMailSevice)}");
            Console.WriteLine($"Subject:{subject}");
            Console.WriteLine($"Message:{message}");
        }
    }
}
