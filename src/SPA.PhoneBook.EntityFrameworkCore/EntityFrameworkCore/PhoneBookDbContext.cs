using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SPA.PhoneBook.Authorization.Roles;
using SPA.PhoneBook.Authorization.Users;
using SPA.PhoneBook.MultiTenancy;
using SPA.PhoneBook.PhoneBooks.Persons;
using SPA.PhoneBook.PhoneBooks.PhoneNumbers;

namespace SPA.PhoneBook.EntityFrameworkCore
{
    public class PhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public PhoneBookDbContext(DbContextOptions<PhoneBookDbContext> options)
            : base(options)
        {
        }
    }
}

