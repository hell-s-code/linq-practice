using LinqPractice.Datasets;
using LinqPractice.Models;

namespace LinqPractice;

public class Chapter5
{
    DataSets dataSets = new DataSets();

    // Quantifier Operations
    /********************************************/
    /*** หากต้องการเช็คข้อมูลว่า มีบางตัวไหม หรือ มีทุกตัวไหม เราจะใช้ Any กับ All
    /*** ข้อมูลใช้ตัวแปร dataSets.Employees
    /*** Field ของ dataSets.Employees มีดังนี้
    /*** 1. EmployeeCode: string
    /*** 2. Name: string           
    /*** 3. Birthday?: Datetime
    /*** 4. Gender: string Man, Women, LGBT
    /*** 5. Single: bool true = โสด
    /********************************************/

    #region No.1
    public bool จงตรวจสอบว่าข้อมูลEmployeeมีวันเกิดทุกคนไหม()
    {
        return dataSets.Employees.All(o => o.Birthday.HasValue);
    }

    [Test]
    public void จงตรวจสอบว่าข้อมูลEmployeeมีวันเกิดทุกคนไหมTest()
    {
        Assert.That(จงตรวจสอบว่าข้อมูลEmployeeมีวันเกิดทุกคนไหม(), Is.EqualTo(false));
    }
    #endregion

    #region No.2
    public bool จงตรวจสอบว่าEmployeeมีคนที่โสดบ้างไหม()
    {
        return dataSets.Employees.Any(o => o.Single);
    }

    [Test]
    public void จงตรวจสอบว่าEmployeeมีคนที่โสดบ้างไหมTest()
    {
        Assert.That(จงตรวจสอบว่าEmployeeมีคนที่โสดบ้างไหม(), Is.EqualTo(true));
    }
    #endregion
}
