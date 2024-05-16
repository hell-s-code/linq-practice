﻿using LinqPractice.Datasets;
using LinqPractice.Models;

namespace LinqPractice;

public class Chapter7
{
    DataSets dataSets = new DataSets();

    // Aggregation Operations
    /********************************************/
    /*** เป็นกลุ่มคำสั่งที่ได้ผลลัพท์กลับมาเลย เช่น Sum,Average, Max , Min, Count 
    /*** ข้อมูลใช้ตัวแปร dataSets.Employees
    /*** Field ของ dataSets.Employees มีดังนี้
    /*** 1. EmployeeCode: string
    /*** 2. Name: string           
    /*** 3. Birthday?: Datetime
    /*** 4. Gender: string Man, Women, LGBT
    /*** 5. Single: bool true = โสด
    /********************************************/

    #region No.1
    public int จงแสดงจำนวนคนที่มีสถานะโสด()
    {
        return 0;
    }

    [Test]
    public void Test1()
    {
        Assert.That(จงแสดงจำนวนคนที่มีสถานะโสด(), Is.EqualTo(5));
    }
    #endregion

    #region No.2
    public double จงแสดงค่าเฉลี่ยของตัวอักษรของชื่อพนักงาน()
    {
        return 0;
    }

    [Test]
    public void Test2()
    {
        Assert.That(จงแสดงค่าเฉลี่ยของตัวอักษรของชื่อพนักงาน(), Is.EqualTo((34d/13d)));
    }
    #endregion

    #region No.3
    public double จงหาว่าชื่อคนที่ยาวที่สุดกี่ตัวอักษร()
    {
        return 0;
    }

    [Test]
    public void Test3()
    {
        Assert.That(จงหาว่าชื่อคนที่ยาวที่สุดกี่ตัวอักษร(), Is.EqualTo(4d));
    }
    #endregion

    #region No.4
    public double จงหาว่าชื่อคนที่สั้นที่สุดกี่ตัวอักษร()
    {
        return 0;
    }

    [Test]
    public void Test4()
    {
        Assert.That(จงหาว่าชื่อคนที่สั้นที่สุดกี่ตัวอักษร(), Is.EqualTo(1d));
    }
    #endregion
}
