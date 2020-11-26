using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gradinaru_Alexandra_Lab8.Models;

namespace Gradinaru_Alexandra_Lab8.Data
{
    public class Gradinaru_Alexandra_Lab8Context : DbContext
    {
        public Gradinaru_Alexandra_Lab8Context (DbContextOptions<Gradinaru_Alexandra_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Gradinaru_Alexandra_Lab8.Models.Book> Book { get; set; }

        public DbSet<Gradinaru_Alexandra_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Gradinaru_Alexandra_Lab8.Models.Category> Category { get; set; }
    }
}
