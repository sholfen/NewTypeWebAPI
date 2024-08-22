using DataModelLib.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public partial class BaseDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
