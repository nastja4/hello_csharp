﻿int examAssignments = 5;

// Student names
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];

int[] studentScores = [];
string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{   
    if (name == "Sophia")
        studentScores = sophiaScores;
    else if (name == "Andrew")
        studentScores = andrewScores;
    else if (name == "Emma")
        studentScores = emmaScores;
    else if (name == "Logan")
        studentScores = loganScores;

    int gradedAssignments = 0;
    int gradedExtraCreditAssignments = 0; 

    int sumExamScores = 0;
    int sumExtraCreditScores = 0;

    decimal currentStudentGrade = 0;
    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraCreditScore = 0;
    
    foreach (int score in studentScores)
    {
        gradedAssignments ++;
        if (gradedAssignments <= examAssignments)
        {
            sumExamScores += score; 
        }
        else 
        {
            gradedExtraCreditAssignments ++;
            sumExtraCreditScores += score;   
        }                 
    }

    currentStudentExamScore = (decimal)sumExamScores / examAssignments;
    currentStudentExtraCreditScore = (decimal)sumExtraCreditScores / gradedExtraCreditAssignments;     

    currentStudentGrade = (sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";
    
    // Console.WriteLine($"{name}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");     
    Console.WriteLine($"{name}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(decimal)sumExtraCreditScores / 10 / examAssignments} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
