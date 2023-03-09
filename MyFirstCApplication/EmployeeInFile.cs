namespace MyFirstCApplication
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddDelegate GradeAdded;

        private const string fileName = "grades.txt";

        public EmployeeInFile(string name,
                              string surname,
                              int age,
                              char sex,
                              string position,
                              int seniority)
            : base(name, surname, age, sex, position, seniority)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);

                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("Wprowadzona ocena wykracza poza dopuszczalny zakres wartości: od 0 do 100.\n");
            }
        }

        public override void AddGrade(string grade)
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
                _ => throw new Exception("Wprowadzono wartość spoza dopuszczalnego zakresu.\n"),
            };

            {
                this.AddGrade(gradeToAdd);
            }
        }

        public override void AddGrade(double grade)
        {
            float resultDouble = (float)grade;
            this.AddGrade(resultDouble);
        }

        public override void AddGrade(long grade)
        {
            float resultLong = (float)grade;
            this.AddGrade(resultLong);
        }

        public override void AddGrade(decimal grade)
        {
            float resultDecimal = (float)grade;
            this.AddGrade(resultDecimal);
        }

        public override void AddGrade(int grade)
        {
            float resultInt = grade;
            this.AddGrade(resultInt);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        var grade = float.Parse(line);
                        statistics.AddGrade(grade);
                        line = reader.ReadLine();
                    }
                }
            }
            return statistics;
        }
    }
}
