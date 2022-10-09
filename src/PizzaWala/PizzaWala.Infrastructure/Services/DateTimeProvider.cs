using PizzaWala.Application.Common.Interfaces.Services;

namespace PizzaWala.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
