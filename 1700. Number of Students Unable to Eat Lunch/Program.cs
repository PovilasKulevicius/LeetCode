namespace _1700._Number_of_Students_Unable_to_Eat_Lunch;

abstract class Solution
{
    static void Main()
    {
        var (students, sandwiches) = GetInitialData();
        var results = CountStudents(students, sandwiches);
        OutputResult(results);
        
    }

    private static void OutputResult(int result)
    {
        Console.Write(result);
    }

    private static int CountStudents(int[] students, int[] sandwiches)
    {
        var studentList = new List<int>(students);
        var sandwichesList = new List<int>(sandwiches);

        var currentSandwich = 0;
        var currentStudent = 0;

        var studentsWhoDidNotEat = 0;
        
        while (studentList.Count > 0 || sandwichesList.Count > 0)
        {
            if (studentList[currentStudent] == sandwichesList[currentSandwich])
            {
                studentList.RemoveAt(currentStudent);
                sandwichesList.RemoveAt(currentSandwich);
                studentsWhoDidNotEat = 0;
            }
            else
            {
                studentList.Add(studentList[currentStudent]);
                studentList.RemoveAt(currentStudent);
                studentsWhoDidNotEat++;

                if (studentsWhoDidNotEat == studentList.Count)
                {
                    return studentsWhoDidNotEat;
                }
            }
        }

        return studentsWhoDidNotEat;
    }

    private static (int[], int[]) GetInitialData()
    {
        var students = new[] {1,1,0,0};
        var sandwiches = new [] {0,1,0,1};
        
        return (students, sandwiches);
    }
}