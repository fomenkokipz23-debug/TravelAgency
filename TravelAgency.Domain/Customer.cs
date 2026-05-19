using System;

namespace TravelAgency.Domain
{
    public class Customer : IDisposable
    {
        private bool _disposed = false;

        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string name, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Console.WriteLine($"[Constructor] Клієнт {Name} створений.");
        }

        public Customer(Customer previousCustomer)
        {
            if (previousCustomer == null) throw new ArgumentNullException(nameof(previousCustomer));
            
            Id = previousCustomer.Id;
            Name = previousCustomer.Name;
            Email = previousCustomer.Email;
            Console.WriteLine($"[Copy Constructor] Копія клієнта {Name} створена.");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Console.WriteLine($"[Dispose] Ресурси клієнта {Name} успішно звільнено.");
                }
                _disposed = true;
            }
        }

        ~Customer()
        {
            Dispose(false);
        }
    }
}