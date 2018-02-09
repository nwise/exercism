using System;
using System.Collections.Generic;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{    

    public Dictionary<string, List<Plant>> Garden = new Dictionary<string, List<Plant>>();
    public string[] students = new string[] {"Alice", "Bob", "Charlie", "David", "Eve", "Fred", "Ginny",
                                             "Harriet", "Ileana", "Joseph", "Kincaid", "Larry"};

    public KindergartenGarden(string diagram)
    {
        string[] gardenRows = diagram.Split('\n');
        foreach(string row in gardenRows)
        {
            for (int rowPos = 0; rowPos < row.Length; rowPos+=2)
            {
                string rowPart = row.Substring(rowPos,2);

                string plantCharOne = rowPart.Substring(0,1);
                string plantCharTwo = rowPart.Substring(1,1);

                Plant plantOne = selectPlant(plantCharOne);
                Plant plantTwo = selectPlant(plantCharTwo);

                string student = students[(rowPos/2)];
                SetPlant(student, plantOne); 
                SetPlant(student, plantTwo); 
            }
        }
    }

    public IEnumerable<Plant> Plants(string student)
    {
        return Garden[student];
    }

    public void SetPlant(string student, Plant plant)
    {
        if(!Garden.ContainsKey(student)) {
          Garden.Add(student, new List<Plant>());
        }
        Garden[student].Add(plant);
    }

    public Plant selectPlant(string plantChar)
    {
        var plant = Plant.Clover;
        switch(plantChar){
            case "C":
                plant = Plant.Clover;
                break;
            case "G":
                plant = Plant.Grass;
                break;
            case "R":
                plant = Plant.Radishes;
                break;
            case "V":
                plant = Plant.Violets;
                break;
        }
        return plant;
    }

}