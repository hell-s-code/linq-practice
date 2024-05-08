using LinqPractice.Contains;

namespace LinqPractice.Models;

public class Employee
{
    public string EmployeeCode { get; set; }
    public string Name { get; set; }
    public DateTime? Birthday { get; set; }
    public string Gender { get; set; }
    public bool Single { get; set; }
}
