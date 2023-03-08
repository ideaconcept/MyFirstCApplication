namespace MyFirstCApplication
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, int age, char sex, string position, int seniority)

        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Sex = sex;
            this.Position = position;
            this.Seniority = seniority;
        }

        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public char Sex { get; }
        public string Position { get; }
        public int Seniority { get; }

        public void AddGrade(string grade)
        {
            var gradeToAdd = grade switch //Dogrzebałem się w necie nowej składni w C# 8.0 :-)
            {
                "6" => 100,
                "-6" or "6-" => 95,
                "+5" or "5+" => 85,
                "5" => 80,
                "-5" or "5-" => 75,
                "+4" or "4+" => 65,
                "4" => 60,
                "-4" or "4-" => 55,
                "+3" or "3+" => 45,
                "3" => 40,
                "-3" or "3-" => 35,
                "+2" or "2+" => 25,
                "2" => 20,
                "-2" or "2-" => 15,
                "+1" or "1+" => 5,
                "1" => 0,
                _ when float.TryParse(grade, out float result) => result,
                _ => throw new Exception("Wprowadzono wartość spoza dopuszczalnego zakresu."),
            };

            {
                this.AddGrade(gradeToAdd);
            }
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Wprowadzona ocena wykracza poza dopuszczalny zakres wartości: od 0 do 100.");
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
