using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Domain.Entities.Booking;
using Tarker.Booking.Domain.Entities.Customer;
using Tarker.Booking.Domain.Entities.User;

namespace Tarker.Booking.Application.Interfaces
{
    public interface IDBService
    {
        DbSet<UserEntity> User { get; set; }
        DbSet<CustomerEntity> Customer { get; set; }
        DbSet<BookingEntity> Booking { get; set; }

        Task<bool> SaveAsync();
    }
}
