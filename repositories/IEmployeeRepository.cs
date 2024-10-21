using EmployeeInfo.Models;

namespace EmployeeInfo.repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int id);
    }
}
