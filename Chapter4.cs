using LinqPractice.Datasets;
using LinqPractice.Models;

namespace LinqPractice;

public class Chapter4
{
    DataSets dataSets = new DataSets();

    // Sorting Data
    /********************************************/
    /*** การเรียงลำดับจาก น้อยไปมาก และมากไปน้อย จะใช้ (OrderBy น้อยไปมาก) และ (OrderByDescending มากไปน้อย)
    /*** ข้อมูลใช้ตัวแปร dataSets.Employees
    /*** Field ของ dataSets.Employees มีดังนี้
    /*** 1. EmployeeCode: string
    /*** 2. Name: string           
    /*** 3. Birthday?: Datetime
    /*** 4. Gender: string Man, Women, LGBT
    /*** 5. Single: bool true = โสด
    /********************************************/

    #region No.1
    public List<Employee> จงเรียงลำดับชื่อพนักงานจากน้อยไปมาก()
    {
        return new();
    }

    [Test]
    public void Test1()
    {
        Assert.That(จงเรียงลำดับชื่อพนักงานจากน้อยไปมาก(), Is.EqualTo(dataSets.Chapter4Result1));
    }
    #endregion

    #region No.2
    public List<Employee> จงเรียงลำดับวันเกิดพนักงานจากมากไปน้อย()
    {
        return new();
    }

    [Test]
    public void Test2()
    {
        Assert.That(จงเรียงลำดับวันเกิดพนักงานจากมากไปน้อย(), Is.EqualTo(dataSets.Chapter4Result2));
    }
    #endregion
}
