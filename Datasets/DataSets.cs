using LinqPractice.Contains;
using LinqPractice.Models;

namespace LinqPractice.Datasets;

partial class DataSets
{
    public List<Employee> Employees = new List<Employee>
    {
        new Employee()
        {
            EmployeeCode = "46001",
            Name = "Boss",
            Birthday = new DateTime(1990, 4, 12),
            Gender = Gender.Man,
            Single = false
        },
        new Employee()
        {
            EmployeeCode = "61025",
            Name = "J",
            Birthday = new DateTime(1995, 8, 9),
            Gender = Gender.Man,
            Single = false
        },
        new Employee()
        {
            EmployeeCode = "62038",
            Name = "E",
            Gender = Gender.Man,
            Single = false
        },
        new Employee()
        {
            EmployeeCode = "58011",
            Name = "WY",
            Birthday = new DateTime(1992, 4, 29),
            Gender = Gender.Women,
            Single = false
        },
        new Employee()
        {
            EmployeeCode = "64092",
            Name = "BT",
            Birthday = new DateTime(1998, 12, 25),
            Gender = Gender.Women,
            Single = false
        },
        new Employee()
        {
            EmployeeCode = "65199",
            Name = "CYT",
            Birthday = new DateTime(1999, 10, 23),
            Gender = Gender.Women,
            Single = true
        },
        new Employee()
        {
            EmployeeCode = "65200",
            Name = "NTP",
            Birthday = new DateTime(1998, 2, 28),
            Gender = Gender.Man,
            Single = false
        },
        new Employee()
        {
            EmployeeCode = "65049",
            Name = "NTN",
            Birthday = new DateTime(2000, 7, 14),
            Gender = Gender.Man,
            Single = false
        },
        new Employee()
        {
            EmployeeCode = "65005",
            Name = "KSK",
            Birthday = new DateTime(1998, 5, 1),
            Gender = Gender.Man,
            Single = true
        },
        new Employee()
        {
            EmployeeCode = "66084",
            Name = "SNP",
            Birthday = new DateTime(1993, 9, 10),
            Gender = Gender.Women,
            Single = false
        },
        new Employee()
        {
            EmployeeCode = "67001",
            Name = "PKW",
            Birthday = new DateTime(2000, 8, 20),
            Gender = Gender.Man,
            Single = true
        },
        new Employee()
        {
            EmployeeCode = "67002",
            Name = "CHWR",
            Birthday = new DateTime(2004, 3, 31),
            Gender = Gender.Man,
            Single = true
        },
        new Employee()
        {
            EmployeeCode = "67003",
            Name = "NN",
            Birthday = new DateTime(2004, 11, 9),
            Gender = Gender.Women,
            Single = true
        },
    };

    public List<Employee> Chapter1Result1 = new List<Employee>();
    public List<Employee> Chapter1Result2 = new List<Employee>();
    public List<Employee> Chapter1Result3 = new List<Employee>();
    public List<Employee> Chapter1Result4 = new List<Employee>();
    public List<Employee> Chapter1Result5 = new List<Employee>();
    public List<string> Chapter2Result1 = new List<string>();
    public List<string> Chapter2Result2 = new List<string>();
    public List<string> Chapter2Result3 = new List<string>();
    public Employee Chapter3Result1 = new();
    public Employee Chapter3Result2 = new();
    public List<Employee> Chapter4Result1 = new List<Employee>();
    public List<Employee> Chapter4Result2 = new List<Employee>();
    public List<IGrouping<bool, Employee>> Chapter6Result1 = new();

    public DataSets()
    {
        Chapter1Result1 = Employees.Where(w => w.EmployeeCode == "61025").ToList();
        Chapter1Result2 = Employees.Where(w => w.Name.Contains("T")).ToList();
        Chapter1Result3 = Employees.Where(w => !w.Birthday.HasValue).ToList();
        Chapter1Result4 = Employees.Where(w => w.Single).ToList();
        Chapter1Result5 = Employees.Where(w => w.Name.StartsWith("N") && w.Single).ToList();
        Chapter2Result1 = Employees.Select(s => s.Gender == Gender.Man ? $"นาย {s.Name}" : $"นางสาว {s.Name}").ToList();
        Chapter2Result2 = Employees.Select(s => s.Single ? "โสด" : "ไม่โสด").ToList();
        Chapter2Result3 = Employees.Select(s => s.EmployeeCode + s.Name).ToList();
        Chapter3Result1 = Employees.FirstOrDefault();
        Chapter3Result2 = Employees.LastOrDefault();
        Chapter4Result1 = Employees.OrderBy(o => o.Name).ToList();
        Chapter4Result2 = Employees.OrderByDescending(o => o.Birthday).ToList();
        Chapter6Result1 = Employees.GroupBy(g => g.Single).ToList();
    }
}


