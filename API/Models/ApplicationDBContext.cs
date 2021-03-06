using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testWebApi.API.Models;

namespace API.Models
{
 public class ApplicationDBContext : DbContext
 {
  public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
  public DbSet<Employee> Employee { get; set; }

 }
}