using Escola.Entities.Enums;

namespace Escola.Entities {
    public class Employee : Pessoa {

        private static int EmployeeId = 0;

        public int Id { get; set; }
        public Setor Setor { get; set; }

        public Employee(string name, int age) 
            : base(name, age) 
        {  
            Id = EmployeeId++;
        }

        public Employee(string name, int age, Setor setor)
            : this(name, age) 
        {
            Setor = setor;
        }

    }
}
