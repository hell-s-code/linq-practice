
using LinqPractice.Datasets;
using LinqPractice.Models;

namespace LinqPractice;

public class Chapter1
{
    DataSets dataSets = new DataSets();

    // Filtering Data
    /********************************************/
    /*** ����ǹ�˭��� Filter ���� Method Where
    /*** ������������ dataSets.Employees
    /*** Field �ͧ dataSets.Employees �մѧ���
    /*** 1. EmployeeCode: string
    /*** 2. Name: string           
    /*** 3. Birthday?: Datetime
    /*** 4. Gender: string Man, Women, LGBT
    /*** 5. Single: bool true = �ʴ
    /********************************************/

    #region No.1
    public List<Employee> ���Ң����ž�ѡ�ҹ�ҡ���ʾ�ѡ�ҹ61025()
    {
        return dataSets.Employees.Where(w => w.EmployeeCode == "61025").ToList();
    }

    [Test]
    public void ���Ң����ž�ѡ�ҹ�ҡ���ʾ�ѡ�ҹ61025Test()
    {
        Assert.That(���Ң����ž�ѡ�ҹ�ҡ���ʾ�ѡ�ҹ61025(), Is.EqualTo(dataSets.Chapter1Result1));
    }
    #endregion

    #region No.2
    public List<Employee> ���Ң����ž�ѡ�ҹ�ҡ����յ��T����㹪���()
    {
        return dataSets.Employees.Where(w => w.Name.Contains("T")).ToList();
    }

    [Test]
    public void ���Ң����ž�ѡ�ҹ�ҡ����յ��T����㹪���Test()
    {
        Assert.That(���Ң����ž�ѡ�ҹ�ҡ����յ��T����㹪���(), Is.EqualTo(dataSets.Chapter1Result2));
    }
    #endregion

    #region No.3
    public List<Employee> ���Ң����ž�ѡ�ҹ���������ѹ�Դ()
    {
        return dataSets.Employees.Where(w => !w.Birthday.HasValue).ToList();
    }

    [Test]
    public void ���Ң����ž�ѡ�ҹ���������ѹ�ԴTest()
    {
        Assert.That(���Ң����ž�ѡ�ҹ���������ѹ�Դ(), Is.EqualTo(dataSets.Chapter1Result3));
    }
    #endregion

    #region No.4
    public List<Employee> ���Ң����ž�ѡ�ҹ�����ʶҹ��ʴ()
    {
        return dataSets.Employees.Where(w => w.Single).ToList();
    }

    [Test]
    public void ���Ң����ž�ѡ�ҹ�����ʶҹ��ʴTest()
    {
        Assert.That(���Ң����ž�ѡ�ҹ�����ʶҹ��ʴ(), Is.EqualTo(dataSets.Chapter1Result4));
    }
    #endregion

    #region No.5
    public List<Employee> ���Ң����ž�ѡ�ҹ����ժ��͢�鹵鹴��µ��N�����ʶҹ��ʴ()
    {
        return dataSets.Employees.Where(w => w.Single && w.Name.StartsWith("N")).ToList();
    }

    [Test]
    public void ���Ң����ž�ѡ�ҹ����ժ��͢�鹵鹴��µ��N�����ʶҹ��ʴTest()
    {
        Assert.That(���Ң����ž�ѡ�ҹ����ժ��͢�鹵鹴��µ��N�����ʶҹ��ʴ(), Is.EqualTo(dataSets.Chapter1Result5));
    }
    #endregion

}