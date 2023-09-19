using System;
using System.Collections.Generic;
public class OOP {
  public static void Main (string [] args){
    Random grade = new Random ();
    Students [] student = new Students[3];
    student[0] = new Students ("Ivan", 8 , grade.Next(0, 101));
    student[1] = new Students ("Petka", 7, grade.Next (0,101));
    student[2] = new Students ("Roman", 9);
    student[1].evaluate();
  }
}
public class Students{
  private string name;
  private int section;
  private int finalGrade;
  private static List <int> grades = new List <int> ();

  public Students (string name, int section, int finalGrade){
    this.name = name;
    this.section = section;
    this.finalGrade = finalGrade;
    grades.Add(finalGrade);
  }

  public Students (string name, int section){
    this.name = name;
    this.section = section;
  }
  public void evaluate (){
    string eval = "";
    if(finalGrade!=0){
      int sumgrade = 0;
      for (int i = 0; i<grades.Count; i++){
        sumgrade+=grades[i];
      }
      int avggrade = sumgrade/grades.Count;
      if (finalGrade <= 35){
        eval = "poor";
      }
      else if (finalGrade <= 50){
        eval = "satisfactory";
      }
      else if (finalGrade <= 70){
        eval = "good";
      }
      else if (finalGrade <=85){
        eval = "very good";
      }
      else if (finalGrade <= 95){
        eval = "excellent";
      }
      else {
        eval = "exceed expactations";
      }
      Console.WriteLine($"Hello my name is {name}. I am a student in section {section} and my final grade is {finalGrade}, which is {eval}. The average of the class is {avggrade}.");
    }
    else {
      Console.WriteLine($"Hello my name is {name}. I am a student in section {section} and I haven't taken the test.");
    }

  }
}
