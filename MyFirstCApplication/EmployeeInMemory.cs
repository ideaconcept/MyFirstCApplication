namespace MyFirstCApplication
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name,
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
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Wprowadzona ocena wykracza poza dopuszczalny zakres wartości: od 0 do 100.\n");
            }
        }

        public override void AddGrade(string grade)
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
                        throw new Exception("Wprowadzona ocena nie jest dopuszczalną literą z zakresu A - E (a - e).\n");
                }
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
