using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testWebApi.API.Models;

namespace API.Interfaces
{
    public interface IEmployeeRepository:IRepositoryBase<Employee>
    {
        Task<ICollection<Employee>> GetEmployees();

        Task<Employee> GetEmployees(int id);
      }
}