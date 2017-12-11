using System;
using System.Collections.Generic;

public class School
{
    public Dictionary<int, List<string>> list = new Dictionary<int, List<string>>();

    public void Add(string student, int grade)
    {
        if(!list.ContainsKey(grade)){
            InitGrade(grade);
        } 
        list[grade].Add(student);
        list[grade].Sort();
    }

    public IEnumerable<string> Roster()
    {
        List<int> grades = new List<int>(list.Keys);
        List<string> students = new List<string>();
        grades.Sort();
        foreach(int grade in grades){
            foreach(string student in list[grade]){
                students.Add(student);
            }
        }
        return students;
    }

    public IEnumerable<string> Grade(int grade)
    {
        if(!list.ContainsKey(grade)){
            InitGrade(grade);
        }
        return list[grade];
    }

    private void InitGrade(int grade){
        list.Add(grade, new List<string>()); 
    }
}