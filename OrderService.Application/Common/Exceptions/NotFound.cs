using System;

namespace OrderService.Application.Common.Exceptions
{
    public class NotFound : Exception
    {
        public NotFound(string name, object key) : base($"Entity \"{name}\" ({key}) was not found.")
        {

        }
    }
}
