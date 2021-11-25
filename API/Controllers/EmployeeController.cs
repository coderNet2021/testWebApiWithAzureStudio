using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using testWebApi.API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeController(IEmployeeRepository repo)
        {
        _repo = repo;
        }

        [HttpGet]
        [Route("GetEmployee/{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            CommonResponse<Employee> commonResponse = new CommonResponse<Employee>();
            try
            {
                commonResponse.dataenum = await _repo.FindById(id);
                commonResponse.message = "test";
                commonResponse.status=1;

            }
            catch (Exception e)
            {
                commonResponse.message = e.Message;
                commonResponse.status = 2;
            }
            return Ok(commonResponse);
        }

        [HttpGet]
        [Route("GetEmployee")]
        public async Task<IActionResult> GetEmployees()
        {
            CommonResponse<ICollection<Employee>> commonResponse = new CommonResponse<ICollection<Employee>>();
            try
            {
                commonResponse.dataenum = await _repo.FindAll();
                commonResponse.message = "test";
                commonResponse.status=1;

            }
            catch (Exception e)
            {
                commonResponse.message = e.Message;
                commonResponse.status = 2;
            }
            return Ok(commonResponse);
        }
    }
}