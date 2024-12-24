using UnityEditor.Experimental.GraphView;using UnityEngine;

public class HoweWork : MonoBehaviour
{
    void Start()
    {
        University university = new University(5, "ITMO");

        Faculty piikt = new Faculty("piikr", 1);
        Faculty sppo = new Faculty("sppo", 2);
        
        university.AddFaculty(piikt);
        university.AddFaculty(sppo);

        Debug.Log(university.GetFacultyiesName());
    }
}

public class University
{
    public Faculty[] Faculties;
    public string Name;

    private int CurrentFacultiesNumber = 0;
    
    public University(int facultetsCount, string name)
    {
        Faculties = new Faculty[facultetsCount];
        Name = name;
    }

    public void AddFaculty(Faculty faculty)
    {
        Faculties[CurrentFacultiesNumber] = faculty;
        CurrentFacultiesNumber++;
    }

    public string GetFacultyiesName()
    {
        string res = "";
        for (int i = 0; i < CurrentFacultiesNumber; i++)
        {
            res = res + Faculties[i].Name + ", ";
        }

        return res;
    }
}

public class Faculty
{
    public string Name;
    public int Number;

    public Faculty(string name, int number)
    {
        Name = name;
        Number = number;
    }
}