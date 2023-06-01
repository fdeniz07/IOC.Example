using Microsoft.Extensions.Logging;
using System;

namespace IOC.Web.Models
{
    public class DateService : ISingletonDateService, IScopedDateService, ITransientDateService
    {
        private readonly ILogger<DateService> _logger;

        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;

            _logger.LogWarning("DateService constructor'ina girdi");
        }

        public DateTime GetDateTime { get; } = DateTime.Now;
    }
}
