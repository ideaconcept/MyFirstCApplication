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
                Console.WriteLine("Wprowadzona ocena wykracza poza dopuszczalny zakres wartości: od 0 do 100.");
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
                Console.WriteLine("Wprowadzona ocena nie jest wartością numeryczną.");
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

        public void AddGrade(char grade)
        {
            float resultChar = (float)grade;
            if (resultChar >= 64 && resultChar <= 87)
            {
                this.AddGrade(resultChar - 64);
            }
            else
            {
                Console.WriteLine("Wprowadzona ocena nie jest wartością numeryczną. Wprowadziłeś znak.");
            }
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
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i=0; i<this.grades.Count; i=i+1)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;
            
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);        

            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;
           
            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            } 

            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}