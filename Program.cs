
// iman fatahi
// tamrin shomare 7



using System.Data;
using System.Runtime.CompilerServices;

List<Student> students = new List<Student>();
StreamReader sr = new StreamReader(@"E:\visual studio codes\tamrin shomare 7\tamrin shomare 7\students.txt");
Student[] Students = new Student[100];
string yesorno;
while (!sr.EndOfStream)
{
    string line = sr.ReadLine();
    Student student = new Student();

    student.FName = line.Split(',')[0];
  
    student.pishrafte1mark = Convert.ToDouble(line.Split(',')[1]);
    student.tafsirmark = Convert.ToDouble(line.Split(',')[2]); 
    student.riazimark = Convert.ToDouble(line.Split(',')[3]); 
    student.kargahmark = Convert.ToDouble(line.Split(',')[4]); 
    student.zabanmark = Convert.ToDouble(line.Split(',')[5]);
    student.pishrafte2mark = Convert.ToDouble(line.Split(',')[6]); 
    student.sheygraeemark = Convert.ToDouble(line.Split(',')[7]);
    student.tarbiatbadanimark = Convert.ToDouble(line.Split(',')[8]);
    student.systemamelmark = Convert.ToDouble(line.Split(',')[9]);
    student.algoritmmark = Convert.ToDouble(line.Split(',')[10]);


    students.Add(student);
}



    Console.WriteLine("choose one of these numbers  :");
    Console.WriteLine("1 = TotalAverage / 2 = PracticalAverage / 3 = TheoryAverage / 4 = MainAverage / 5 = grade of TotalAverages / 6 = grade of PracticalAverage / 7 = grade of TheoryAverage / 8 = grade of MainAverage ");

    int x = Convert.ToInt32(Console.ReadLine());



    if (x == 1)
    {
        foreach (var student in students)
        {

            Console.WriteLine(student.FName + "=" + student.TotalAverage());



        }
    }

    if (x == 2)
    {
        foreach (var student in students)
        {

            Console.WriteLine(student.FName + "=" + student.PracticalAverage());



        }
    }


    if (x == 3)
    {
        foreach (var student in students)
        {

            Console.WriteLine(student.FName + "=" + student.TheoryAverage());



        }
    }


    if (x == 4)
    {
        foreach (var student in students)
        {

            Console.WriteLine(student.FName + "=" + student.MainAverage());



        }
    }
    if (x == 5)
    {
        foreach (var student in students)
        {
            double Average = student.TotalAverage();
            Console.WriteLine(student.FName + "=" + student.Rank(Average));



        }
    }
    if (x == 6)
    {
        foreach (var student in students)
        {
            double Average = student.PracticalAverage();
            Console.WriteLine(student.FName + "=" + student.Rank(Average));

        }

    }

    if (x == 7)
    {
        foreach (var student in students)
        {
            double Average = student.TheoryAverage();

            Console.WriteLine(student.FName + "=" + student.Rank(Average));
        }



    }

    if (x == 8)
    {
        foreach (var student in students)
        {
            double Average = student.MainAverage();
            Console.WriteLine(student.FName + "=" + student.Rank(Average));

        }





    }




class Student
{

    public string FName { get; set; }
   
    public double pishrafte1mark { get; set; }
    public double tafsirmark {  get; set; }
    public double riazimark {  get; set; }
    public double kargahmark { get;set; }
    public double zabanmark {  get; set; }
    public double pishrafte2mark { get; set; }
    public double sheygraeemark { get; set; }
    public double tarbiatbadanimark { get; set; }
    public double systemamelmark {  get; set; }
    public double algoritmmark { get; set; }
   

    public  double TotalAverage()
    {
        return ((pishrafte1mark * 3) + tafsirmark + (riazimark * 2) + kargahmark + (zabanmark * 2) + (pishrafte2mark * 3)

            + (sheygraeemark * 3) + tafsirmark + (systemamelmark * 3) + (algoritmmark * 3)) / 22;
        
    }

    public double PracticalAverage()
    {

        return ((pishrafte1mark * 3) + (pishrafte2mark * 3) + (sheygraeemark * 3)) / 9;

    }
    public double TheoryAverage()
    {
        return((systemamelmark*3)+(algoritmmark*3)) / 6;



    }

    public double MainAverage()
    {

        return ((pishrafte1mark * 3) + (pishrafte2mark * 3) + (sheygraeemark * 3) + (systemamelmark * 3) + (algoritmmark * 3)) / 15;


    }


    public char Rank(double Average )
    {
        char Grade = ' ';


        switch (Average)
        {
            case double average when average is >= 17 and <= 20:
                Grade = 'A';
                break;
            case double average when average is >= 15 and < 17:
                Grade = 'B';
                break;
            case double average when average is >= 13 and <15:
                Grade = 'C';
                break;
            case double average when average is >= 10 and < 13:
                Grade = 'D';
                break;
            case double average when average is >= 7 and <10:
                Grade = 'E';
                break;
            case double average when average is >= 3 and < 7:
                Grade = 'F';
                break;
            case double average when average is >= 0 and < 3:
                Grade = 'G';
                break;
            default:
                break;
        }

        return Grade;
    }

 
   
    
   

   } 
        
        
    
      




 

 
   






   

