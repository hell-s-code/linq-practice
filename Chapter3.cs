using LinqPractice.Datasets;
using LinqPractice.Models;

namespace LinqPractice;

public class Chapter3
{
    DataSets dataSets = new DataSets();

    // Element Operations
    /********************************************/
    /*** ในบางทีเราอยากจะทำงานกับข้อมูลแค่ตัวใดตัวหนึ่งหรือส่วนหนึ่ง FirstOrDefault,LastOrDefault 
    /*** ข้อมูลใช้ตัวแปร dataSets.Employees
    /*** Field ของ dataSets.Employees มีดังนี้
    /*** 1. EmployeeCode: string
    /*** 2. Name: string           
    /*** 3. Birthday?: Datetime
    /*** 4. Gender: string Man, Women, LGBT
    /*** 5. Single: bool true = โสด
    /********************************************/

    #region No.1
    public Employee จงดึงข้อมูลEmployeeที่เป็นข้อมูลแรกของDataSets()
    {
        return new();
    }

    [Test]
    public void Test1()
    {
        Assert.That(จงดึงข้อมูลEmployeeที่เป็นข้อมูลแรกของDataSets(), Is.EqualTo(dataSets.Chapter3Result1));
    }
    #endregion

    #region No.2
    public Employee จงดึงข้อมูลEmployeeที่เป็นข้อมูลสุดท้ายของDataSets()
    {
        return new();
    }

    [Test]
    public void Test2()
    {
        Assert.That(จงดึงข้อมูลEmployeeที่เป็นข้อมูลสุดท้ายของDataSets(), Is.EqualTo(dataSets.Chapter3Result2));
    }
    #endregion
}
