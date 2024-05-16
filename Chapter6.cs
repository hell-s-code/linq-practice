using LinqPractice.Datasets;
using LinqPractice.Models;

namespace LinqPractice;

public class Chapter6
{
    DataSets dataSets = new DataSets();

    // Quantifier Operations
    /********************************************/
    /*** หากต้องการที่จะ Group กลุ่มข้อมูล เราจะใช้ GroupBy
    /*** ข้อมูลใช้ตัวแปร dataSets.Employees
    /*** Field ของ dataSets.Employees มีดังนี้
    /*** 1. EmployeeCode: string
    /*** 2. Name: string           
    /*** 3. Birthday?: Datetime
    /*** 4. Gender: string Man, Women, LGBT
    /*** 5. Single: bool true = โสด // สถานะภาพ
    /********************************************/

    #region No.1
    public List<IGrouping<bool, Employee>> จงGroupข้อมูลสถานะภาพ()
    {
        return new();
    }

    [Test]
    public void Test()
    {
        Assert.That(จงGroupข้อมูลสถานะภาพ(), Is.EqualTo(dataSets.Chapter6Result1));
    }
    #endregion
}
