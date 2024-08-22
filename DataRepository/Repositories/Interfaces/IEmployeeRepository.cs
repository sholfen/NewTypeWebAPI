using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModelLib.DTOs;

namespace DataRepository.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee? GetById(int id);
        void Add(Employee emp);
        Employee? GetEmployee(int id);
        Employee? GetSingle(Func<Employee?, bool> predicate);
        List<Employee> GetList(Func<Employee?, bool> predicate);
        List<Employee> GetListByKey(int key);
    }
}
