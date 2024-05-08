
using LinqPractice.Datasets;
using LinqPractice.Models;

namespace LinqPractice;

public class Chapter1
{
    DataSets dataSets = new DataSets();

    // Filtering Data
    /********************************************/
    /*** โดยส่วนใหญ่การ Filter จะใช้ Method Where
    /*** ข้อมูลใช้ตัวแปร dataSets.Employees
    /*** Field ของ dataSets.Employees มีดังนี้
    /*** 1. EmployeeCode: string
    /*** 2. Name: string           
    /*** 3. Birthday?: Datetime
    /*** 4. Gender: string Man, Women, LGBT
    /*** 5. Single: bool true = โสด
    /********************************************/

    #region No.1
    public List<Employee> จงหาข้อมูลพนักงานจากรหัสพนักงาน61025()
    {
        return dataSets.Employees.Where(w => w.EmployeeCode == "61025").ToList();
    }

    [Test]
    public void จงหาข้อมูลพนักงานจากรหัสพนักงาน61025Test()
    {
        Assert.That(จงหาข้อมูลพนักงานจากรหัสพนักงาน61025(), Is.EqualTo(dataSets.Chapter1Result1));
    }
    #endregion

    #region No.2
    public List<Employee> จงหาข้อมูลพนักงานจากที่มีตัวTอยู่ในชื่อ()
    {
        return dataSets.Employees.Where(w => w.Name.Contains("T")).ToList();
    }

    [Test]
    public void จงหาข้อมูลพนักงานจากที่มีตัวTอยู่ในชื่อTest()
    {
        Assert.That(จงหาข้อมูลพนักงานจากที่มีตัวTอยู่ในชื่อ(), Is.EqualTo(dataSets.Chapter1Result2));
    }
    #endregion

    #region No.3
    public List<Employee> จงหาข้อมูลพนักงานที่ไม่มีวันเกิด()
    {
        return dataSets.Employees.Where(w => !w.Birthday.HasValue).ToList();
    }

    [Test]
    public void จงหาข้อมูลพนักงานที่ไม่มีวันเกิดTest()
    {
        Assert.That(จงหาข้อมูลพนักงานที่ไม่มีวันเกิด(), Is.EqualTo(dataSets.Chapter1Result3));
    }
    #endregion

    #region No.4
    public List<Employee> จงหาข้อมูลพนักงานที่มีสถานะโสด()
    {
        return dataSets.Employees.Where(w => w.Single).ToList();
    }

    [Test]
    public void จงหาข้อมูลพนักงานที่มีสถานะโสดTest()
    {
        Assert.That(จงหาข้อมูลพนักงานที่มีสถานะโสด(), Is.EqualTo(dataSets.Chapter1Result4));
    }
    #endregion

    #region No.5
    public List<Employee> จงหาข้อมูลพนักงานที่มีชื่อขึ้นต้นด้วยตัวNและมีสถานะโสด()
    {
        return dataSets.Employees.Where(w => w.Single && w.Name.StartsWith("N")).ToList();
    }

    [Test]
    public void จงหาข้อมูลพนักงานที่มีชื่อขึ้นต้นด้วยตัวNและมีสถานะโสดTest()
    {
        Assert.That(จงหาข้อมูลพนักงานที่มีชื่อขึ้นต้นด้วยตัวNและมีสถานะโสด(), Is.EqualTo(dataSets.Chapter1Result5));
    }
    #endregion

}