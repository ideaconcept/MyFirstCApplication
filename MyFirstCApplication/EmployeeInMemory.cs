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

                var gradeToAdd = grade switch
                {
                    "A" or "a" => 100,
                    "B" or "b" => 80,
                    "C" or "c" => 60,
                    "D" or "d" => 40,
                    "E" or "e" => 20,
                    _ => throw new Exception("Wprowadzona ocena nie jest dopuszczalną literą z zakresu A - E (a - e).\n"),
                };

                {
                    this.AddGrade(gradeToAdd);
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

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade); 
            }

            return statistics;
        }
    }
}
