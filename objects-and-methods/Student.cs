namespace objects_and_methods;

public class Student
{
    public string name;
    public string major;
    public double gpa;
    public double credit; 

    public Student (string aName, string aMajor, double aGpa, double aCredit)
    {
        name = aName;
        major =aMajor;
        gpa = aGpa;
        credit = aCredit;
    }

    public bool HasHonors () 
    {
        if(gpa >= 3.5)
        {
            return true;
        }
        return false;
    }

    public string GradeLevel()
    {
        if (credit > 128)
        {
            return "You have graduated";
        }
        else if (credit < 128 && credit > 90)
        {
            return "You are a senior";
        }
        else if (credit < 90 && credit > 50)
        {
            return "You are a junior";
        }
        else if (credit < 50 && credit > 20)
        {
            return "You are a sophomore";
        }
        else
        {
            return "Fresman kid";
        }
    }

}
