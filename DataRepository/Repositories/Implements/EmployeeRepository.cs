using DataModelLib.DTOs;
using DataRepository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository.Repositories.Implements
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        private IConfiguration config;

        public EmployeeRepository(IConfiguration configRoot) : base()
        {
            config = configRoot;
        }

        public List<Employee> GetAll()
        {
            var list = Context.Employees.FromSqlRaw("select * from Employees;");
            return list.ToList();
        }

        public Employee? GetById(int id)
        {
            Employee? emp = Context.Employees.Where(e => e.EmployeeID == id).FirstOrDefault();

            return emp;
        }

        public Employee? GetEmployee(int id)
        {
            Employee? emp = (from e in Context.Employees
                             where e.EmployeeID == id
                             select e).FirstOrDefault();

            return emp;
        }

        public void Add(Employee emp)
        {
            Context.Employees.Add(emp);
            Context.SaveChanges();
        }

        public Employee? GetSingle(Func<Employee?, bool> predicate)
        {
            return Context.Employees.FirstOrDefault(predicate);
        }

        public List<Employee> GetList(Func<Employee?, bool> predicate)
        {
            var list = Context.Employees.Where(predicate);
            if (list.Count() != 0)
            {
                return list.ToList();
            }
            return new List<Employee>();
        }

        public List<Employee> GetListByKey(int key)
        {
            List<Employee> list = new List<Employee>();
            //ConfigurationManager

            return list;
        }
    }
}
