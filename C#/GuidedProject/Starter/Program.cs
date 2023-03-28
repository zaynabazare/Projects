

// initialize variables - graded assignments 
int currentAssignments = 5;
string[] studentNames = {"Sophia","Andrew","Emma","Logan"};

int [] studentScores = new int[6];

int[] sophiaScores = {90,86,87,98,100};
int[] andrewScores = {92,89,81,96,90};
int[] emmaScores = {90,85,87,98,68};
int[] loganScores = {90,95,87,88,96};
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
    else{
        studentScores=loganScores;
    }
    int studentSum = 0;
    decimal studentAverage=0; 
    foreach (int score in studentScores){
        studentSum +=score;
    }
    studentAverage = (decimal)studentSum/currentAssignments;
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
