using LinqPractice.Contains;
using LinqPractice.Datasets;

namespace LinqPractice;

public class Chapter2
{
    DataSets dataSets = new DataSets();

    // Projection Operations
    /********************************************/
    /*** Select เป็นการเลือกว่า data source ที่เราไปดึงข้อมูลมา เราจะดัดแปลงแก้ไข หรือ เลือกเอาเฉพาะข้อมูลบางส่วนออกมาใช้
    /*** ข้อมูลใช้ตัวแปร dataSets.Employees
    /*** Field ของ dataSets.Employees มีดังนี้
    /*** 1. EmployeeCode: string
    /*** 2. Name: string           
    /*** 3. Birthday?: Datetime
    /*** 4. Gender: string Man, Women, LGBT
    /*** 5. Single: bool true = โสด
    /********************************************/

    #region No.1
    public List<string> จงเติมคำนำหน้าว่านายถ้าเป็นผู้ชายและเติมคำว่านางสาวหากเป็นผู้หญิงและแสดงชื่อที่ถูกแปลง()
    {
        return dataSets.Employees.Select(s => s.Gender == Gender.Man ? $"นาย {s.Name}" : $"นางสาว {s.Name}").ToList();
    }

    [Test]
    public void จงเติมคำนำหน้าว่านายถ้าเป็นผู้ชายและเติมคำว่านางสาวหากเป็นผู้หญิงและแสดงชื่อที่ถูกแปลงTest()
    {
        Assert.That(จงเติมคำนำหน้าว่านายถ้าเป็นผู้ชายและเติมคำว่านางสาวหากเป็นผู้หญิงและแสดงชื่อที่ถูกแปลง(), Is.EqualTo(dataSets.Chapter2Result1));
    }
    #endregion

    #region No.2
    public List<string> จงแสดงคำว่าโสดหากมีสถานะว่าโสดและแสดงคำว่าไม่โสดหากสถานะไม่โสด()
    {
        return dataSets.Employees.Select(s => s.Single ? "โสด" : $"ไม่โสด").ToList();
    }

    [Test]
    public void จงแสดงคำว่าโสดหากมีสถานะว่าโสดและแสดงคำว่าไม่โสดหากสถานะไม่โสดTest()
    {
        Assert.That(จงแสดงคำว่าโสดหากมีสถานะว่าโสดและแสดงคำว่าไม่โสดหากสถานะไม่โสด(), Is.EqualTo(dataSets.Chapter2Result2));
    }
    #endregion

    #region No.3
    public List<string> จงแสดงรหัสพนักงานและชื่อ()
    {
        return dataSets.Employees.Select(s => s.EmployeeCode + s.Name).ToList();
    }

    [Test]
    public void จงแสดงรหัสพนักงานและชื่อTest()
    {
        Assert.That(จงแสดงรหัสพนักงานและชื่อ(), Is.EqualTo(dataSets.Chapter2Result3));
    }
    #endregion
}