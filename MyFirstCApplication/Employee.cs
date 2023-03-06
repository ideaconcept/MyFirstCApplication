using System;

namespace MyFirstCApplication
{
    public class Employee
    {
       
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        
        public void AddGrade(float grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Wprowadzona ocena wykracza poza dopuszczalny zakres wartości: od 0 do 100.");
            }
        }
        
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                switch (grade)
                {
                    case "A":
                    case "a":
                        this.grades.Add(100);
                        break;
                    case "B":
                    case "b":
                        this.grades.Add(80);
                        break;
                    case "C":
                    case "c":
                        this.grades.Add(60);
                        break;
                    case "D":
                    case "d":
                        this.grades.Add(40);
                        break;
                    case "E":
                    case "e":
                        this.grades.Add(20);
                        break;
                    default:
                        throw new Exception("Wprowadzona ocena nie jest dopuszczalną literą z zakresu A - E (a - e).");
                }
            }                  
        }

        public void AddGrade(double grade)
        {
            float resultDouble = (float)grade;
            this.AddGrade(resultDouble);
        }

        public void AddGrade(long grade)
        {
            float resultLong = (float)grade;
            this.AddGrade(resultLong);
        }

        public void AddGrade(decimal grade)
        {
            float resultDecimal = (float)grade;
            this.AddGrade(resultDecimal);
        }

        public void AddGrade(int grade)
        {
            float resultInt = grade;
            this.AddGrade(resultInt);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
             }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            } 
            return statistics;
        }
    }
}