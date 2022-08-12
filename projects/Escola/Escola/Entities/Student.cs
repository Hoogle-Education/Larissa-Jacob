using Escola.Entities.Enums;

namespace Escola.Entities {
    
    public class Student : Pessoa {

        // atributos
        public long Id { get; set; }
        public double Score { get; private set; }
        public Eletiva Eletiva;

        public Student(string name, int age, Eletiva eletiva) 
            : base(name, age) {
            Eletiva = eletiva;
        }

        // métodos
        public void MakeExam() {
            Random random = new Random();
            Score = random.NextDouble()*10.0;
        }

        public Boolean IsApproved() => (Score > 7.0);

    }
}
