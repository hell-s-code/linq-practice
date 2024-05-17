using Newtonsoft.Json;

namespace linqpractice.DataSource;

public class DataSources
{
    public List<Employee> Employees { get; set; }

    public DataSources()
    {
        string employeeFile = "../../../DataSource/Employees.json";
        string employeeJson = File.ReadAllText(employeeFile);

        Employees = JsonConvert.DeserializeObject<List<Employee>>(employeeJson) ?? new();
    }
}
