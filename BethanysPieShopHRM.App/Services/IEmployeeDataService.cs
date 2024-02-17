using BethanysPieShopHRM.Shared.Domain;
using System.Collections;

namespace BethanysPieShopHRM.App.Services;

public interface IEmployeeDataService
{
    Task<IEnumerable<Employee>> GetAllEmployees(bool refreshRequired = false);
    Task<Employee> GetEmployeeDetails(int employeeId);
    Task<Employee> AddEmployee(Employee employee);
    Task UpdateEmployee(Employee employee);
    Task<Employee> DeleteEmployee(int employeeId);
}
