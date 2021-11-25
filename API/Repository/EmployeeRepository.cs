using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;
using API.Models;
using Microsoft.EntityFrameworkCore;
using testWebApi.API.Models;

namespace API.Repository
{
 public class EmployeeRepository : IEmployeeRepository
 {
  private readonly ApplicationDBContext _db;

  public EmployeeRepository(ApplicationDBContext db)
  {
   _db = db;
  }

  public Task<bool> Create(Employee entity)
  {
   throw new NotImplementedException();
  }

  public Task<bool> Delete(Employee entity)
  {
   throw new NotImplementedException();
  }

  public async Task<ICollection<Employee>> FindAll()
  {
   return await _db.Employee.ToListAsync();
  }

  public Task<Employee> FindById(int id)
  {
   throw new NotImplementedException();
  }

  public Task<ICollection<Employee>> GetEmployees()
  {
   throw new NotImplementedException();
  }

  public Task<Employee> GetEmployees(int id)
  {
   throw new NotImplementedException();
  }

  public Task<bool> isExists(int id)
  {
   throw new NotImplementedException();
  }

  public Task<bool> Save()
  {
   throw new NotImplementedException();
  }

  public Task<bool> Update(Employee entity)
  {
   throw new NotImplementedException();
  }
 }
}