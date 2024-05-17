﻿using linqpractice.DataSource;
/////////////////////////////////////////////////////////////////////////////////////////////////
///
/// Practice LINQ C#
/// ฝึกใช้คำสั่งต่างๆ 
/// DataSource คือ Employees (ข้อมูลพนักงาน)
/// เมื่อ Run Code ห้ามมี Error หรือ Exception ใดๆ
/// โจทย์ที่ให้ทำเป็น Method ส่วนใหญ่ที่ใช้ แต่ไม่ใช่ทั้งหมดที่มีใน Linq ในบางสถานะการณ์อาจจะต้องใช้ Method ที่ไม่มีใน Practice นี้
///
/////////////////////////////////////////////////////////////////////////////////////////////////
List<Employee> Employees = new DataSources().Employees; // DataSource

#region Filter Data

#region No.1 จงแสดงข้อมูลทั้งหมดของพนักงานที่มีชื่อขึ้นต้นด้วยตัวอักษร h
#endregion

#region No.2 จงแสดงข้อมูลทั้งหมดของพนักงานที่มีเงินเดือนมากกว่า 30,000 และมีชื่อขึ้นต้นด้วยตัวอักษร k
#endregion

#region No.3 จงแสดงข้อมูลทั้งหมดของพนักงานที่มีอายุน้อยกว่า 25 ปี และมีเงินเดือนมากกว่า 15,000
#endregion

#region No.4 จงแสดงข้อมูลทั้งหมดของพนักงานที่มีอายุมากกว่า 50 ปี และมีชื่อลงท้ายด้วยตัวอักษร n
#endregion

#region No.5 จงแสดงข้อมูลทั้งหมดของพนักงานที่มีอายุระหว่าง 20 - 40 ปี และมีเงินเดือนน้อยกว่าหรือเท่ากับ 25,000 และชื่อขึ้นต้นด้วยตัวอักษร j หรือมีตัวอักษร o อยู่ทีนามสกุล
#endregion

#endregion

#region Projection Operations

#region No.1 จงแสดงข้อมูลของพนักงานทั้งหมด โดยจะแสดง Firstname, Lastname
#endregion

#region No.2 จงแสดงข้อมูลพนักงานที่มีอายุมากกว่า 30 ปี โดยจะแสดง FullName(ชื่อ + นามสกุล) และ Age(อายุ xx ปี) และ Salary
#endregion

#region No.3 จงแสดงข้อมูลพนักงานที่มีชื่อลงท้ายด้วยตัว m โดยจะแสดง FirstName(แสดงเพียง 3 ตัวอักษรจากด้านหน้า), LastName(แสดงเพียง 2 ตัวอักษรจากด้านหลัง)
#endregion

#region No.4 จงแสดงข้อมูลพนักงานที่มีเงินเดินมากกว่า 15,000 บาท โดยจะแสดง ShotName(ชื่อจริง+_+นามสกุลตัวอักษรแรก 1 ตัวอักษร), Gender, Salary(xxxx บาท)
#endregion

#region No.5 จงแสดงข้อมูลพนักงานที่มี Id มากกว่าหรือเท่ากับ 70 โดยจะแสดง FistName(ตัวพิมพ์ใหญ่), LastName(ตัวพิมพ์ใหญ่), age(อายุ xx ปี), Salary(มีเงิน xx บาท)
#endregion

#endregion

#region Aggregation Operations

#region No.1 จงแสดงผลรวมของจำนวนเงินทั้งของพนักงาน
#endregion

#region No.2 จงแสดงอายุเฉลี่ยของพนักงานทั้งหมด
#endregion

#region No.3 จงแสดงเงินเดือนสูงสุดของพนักงานทั้งหมด
#endregion

#region No.4 จงแสดงจำนวนน้อยที่สุดของพนักงานทั้งหมด
#endregion

#region No.5 จงแสดงจำนวนพนักงานทั้งหมด
#endregion

#region No.6 จงแสดงผลรวมของจำนวนเงินทั้งหมดของพนักงานโดยไม่ใช้ Sum
#endregion

#endregion

#region Element Operations

#region No.1 จงแสดงข้อมูลพนักงานที่มีอายุมากกว่า 30 ปี ให้แสดงข้อมูลแรกที่เจอ
#endregion

#region No.2 จงแสดงข้อมูลพนักงานที่มีอายุมากกว่า 30 ปี ให้แสดงข้อมูลสุดท้ายที่เจอ
#endregion

#region No.3 จงแสดงข้อมูลพนักงานที่มีเงินเดือนมากกว่า 20,000 ให้แสดงข้อมูลแรกที่เจอ โดยจะแสดง FullName(ชื่อ+นามสกุล), JobTitle, Salary(xx บาท)
#endregion

#region No.4 จงแสดงข้อมูลพนักงานที่มีเงินเดือนมากกว่า 20,000 ให้แสดงข้อมูลสุดท้ายที่เจอ โดยจะแสดง FullName(ชื่อ+นามสกุล), JobTitle, Salary(xx บาท)
#endregion

#endregion

#region Partitioning Data

#region No.1 จงแสดงข้อมูลพนักงานที่มีตัวอักษร m อยู่ในชื่อ เอาแค่ 10 ตัวแรกของข้อมูล โดยจะแสดง ShortName(ชื่อ+.+ตัวแรกของนามสกุล), Salary(xx บาท)
#endregion

#region No.2 จงแสดงข้อมูลพนักงานที่มีตัวอักษร a อยู่ในชื่อ เอาแค่ 10 ตัวสุดท้ายของข้อมูล โดยจะแสดง ShortName(ชื่อ+.+ตัวแรกของนามสกุล), Salary(xx บาท)
#endregion

#region No.3 จงแสดงข้อมูลพนักงานที่มีตัวอักษร b อยู่ในชื่อ ไม่เอา 10 ตัวแรกของข้อมูลและเอาข้อมูลเพียง 5 ข้อมูล โดยจะแสดง ShortName(ชื่อ+.+ตัวแรกของนามสกุล), Salary(xx บาท)
#endregion

#region No.4 จงแสดงข้อมูลพนักงานที่มีตัวอักษร c อยู่ในชื่อ ไม่เอา 10 ตัวสุดท้ายของข้อมูลและเอาข้อมูลเพียง 5 ข้อมูล โดยจะแสดง ShortName(ชื่อ+.+ตัวแรกของนามสกุล), Salary(xx บาท)
#endregion

#endregion

#region Sorting Data

#region No.1 จงเรียงลำดับข้อมูลพนักงานเงินเดือนจากมากไปน้อย
#endregion

#region No.2 จงเรียงลำดับตามตัวอักษร JonTitle ของพนักงานจากน้อยไปมาก
#endregion

#region No.3 จงเรียงลำดับชื่อพนักงานจากมากไปน้อยและนามสกุลพนักงานจากน้อยไปมาก
#endregion

#region No.4 จงเรียงลำดับข้อมูลพนักงานแบบย้อนกลับ เช่น นำข้อมูลสุดท้ายมาแทนตัวแรกตามลำดับ
#endregion

#endregion

#region Quantifier Operations

#region No.1 จงเขียนคำสั่ง Linq เพื่อตรวจสอบว่า จากข้อมูลพนักงานทั้งหมดมีคนที่มีอายุเท่ากับ 30 ปีไหม
#endregion

#region No.2 จงเขียนคำสั่ง Linq เพื่อตรวจสอบว่า จากข้อมูลพนักงานทั้งหมดทุกคนมีเงินเดือนใช่หรือไม่
#endregion

#region No.3 จงเขียนคำสั่งเพื่อตรวจสอบว่าพนักงานที่มี Id = 69 มีอยู่ในข้อมูลพนักงานทั้งหมดจาก DataSource หรือไม่ โดยไม่ใช้ Where
#endregion

#endregion

#region Grouping Data

#region No.1 จงแสดงข้อมูลเพศทั้งหมดของพนักงาน(ห้ามซ้ำ) โดยแสดง Gender
#endregion

#region No.2 จงแสดงข้อมูลแต่ละเพศมีเงินเดือนมากสุดเท่าใด โดยแสดง Gender, Salary(xx บาท)
#endregion

#region No.3 จงแสดงข้อมูลแต่ละเพศมีกี่คน โดยแสดง Gender, TotalEmployee(แสดงจำนวนคน)
#endregion

#region No.4 จงแสดงกลุ่มข้อมูลแต่ละเพศมีเงินเดือนเท่าไหร่ โดยแสดง Gender, Salary
#endregion

#endregion