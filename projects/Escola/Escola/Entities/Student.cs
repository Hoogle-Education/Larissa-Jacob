namespace Escola.Entities {
    
    public class Student {

        // atributos
        public string Name;
        private double _score;
        public int Age;

        // auto-property
        public string Phone { get; set; }

        // construtor
        public Student(string name, int age) { 
            Name = name;
            Age = age;
        }

        public Student(string name, int age, string phone) 
            : this(name, age){
            Phone = phone;
        }

        // properties
        public double Score {
            get { return _score; }
            set { 
                if(Score >= 0.0 && Score <= 10.0) {
                    _score = value;
                }
            }
        }

        // métodos
        public void makeExam() {
            Random random = new Random();
            _score = random.NextDouble()*10.0;
        }

        public Boolean IsApproved() => (_score > 7.0) ? true : 

    }
}
