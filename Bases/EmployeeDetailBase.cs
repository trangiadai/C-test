using EmployeeInfo.Models;
using EmployeeInfo.repositories;
using Microsoft.AspNetCore.Components;

namespace EmployeeInfo.Bases
{
    public class EmployeeDetailBase : ComponentBase
    {

        public Employee employees { get; set; } = new Employee();
        [Inject]
        public IEmployeeRepository employeeRepository { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            employees = await employeeRepository.GetEmployeeById(int.Parse(Id));
        }
    }
}
