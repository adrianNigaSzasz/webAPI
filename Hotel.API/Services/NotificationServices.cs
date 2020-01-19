using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Hotel.API.Services
{
	public class NotificationServices : INotificationService
	{
        private readonly Guid id;
        private readonly ILogger<NotificationServices> logger;
        public NotificationServices(ILoggerFactory factory)
        {
            this.logger = factory.CreateLogger<NotificationServices>();

            this.id = Guid.NewGuid();
        }

        public void Notify(string message)
        {
            this.logger.LogInformation($"{this.id} : {message}");
        }
    }
}
