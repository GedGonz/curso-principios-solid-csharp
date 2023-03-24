using OpenClose;

CalculateSalaryMonthly(new List<IEmployee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Carlos Flores", 100)
});


void CalculateSalaryMonthly(List<IEmployee> employees) 
{
    foreach (var employee in employees)
    {
            Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C2} ");
    }

}