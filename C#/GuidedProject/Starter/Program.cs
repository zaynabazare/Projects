

// initialize variables - graded assignments 
int examAssignments = 5;
string[] studentNames = {"Sophia","Andrew","Emma","Logan", "Becky", "Chris", "Eric", "Gregor" };

int [] studentScores = new int[6];

int[] sophiaScores = {90,86,87,98,100,94,90};
int[] andrewScores = {92,89,81,96,90,89};
int[] emmaScores = {90,85,87,98,68,89,89,89};
int[] loganScores = {90,95,87,88,96,96};
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

 Console.WriteLine($"Student \t Grade \n");

foreach(string name in studentNames){
    if(name=="Sophia"){
        studentScores=sophiaScores;
    } 
    else if (name=="Andrew"){
        studentScores=andrewScores;
    }
    else if (name=="Emma"){
        studentScores=emmaScores;
    }
    else if(name=="Logan"){
        studentScores=loganScores;
    }
    else if (name == "Becky")
    studentScores = beckyScores;
    else if (name == "Chris")
    studentScores = chrisScores;
    else if (name == "Eric")
    studentScores = ericScores;
    else if (name == "Gregor")
    studentScores = gregorScores;
    else
    continue;
    int extraAssignments = 0;
    decimal studentSum = 0; 
    decimal studentAverage=0; 

    foreach (int score in studentScores){
        extraAssignments +=1;
        if(extraAssignments<=examAssignments)
             studentSum +=score;
        
        else
            studentSum += (decimal)score /10;
        
       
    }
    studentAverage = (decimal)studentSum/examAssignments;
    string studentGrade ="";
    if (studentAverage >= 97)
        studentGrade = "A+";

    else if (studentAverage >= 93)
        studentGrade = "A";

    else if (studentAverage >= 90)
        studentGrade = "A-";

    else if (studentAverage >= 87)
        studentGrade = "B+";

    else if (studentAverage >= 83)
        studentGrade = "B";

    else if (studentAverage >= 80)
        studentGrade = "B-";

    else if (studentAverage >= 77)
        studentGrade = "C+";

    else if (studentAverage >= 73)
        studentGrade = "C";

    else if (studentAverage >= 70)
        studentGrade = "C-";

    else if (studentAverage >= 67)
        studentGrade = "D+";

    else if (studentAverage >= 63)
        studentGrade = "D";

    else if (studentAverage >= 60)
        studentGrade = "D-";
    Console.WriteLine($"{name} \t \t {studentAverage} \t {studentGrade} ");
    
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
