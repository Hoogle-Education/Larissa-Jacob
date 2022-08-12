namespace Escola.Entities {
    public class Pessoa {

        public string Name { get; set; }
        public string Phone { get; set; }

        public int _age;

        public Pessoa(string name, int age) {
            Name = name;
            _age = age;
        }

        public Pessoa(string name, int age, string phone) {
            Name = name;
            _age = age;
            Phone = phone;
        }

        // properties
        public int Age {
            get { return _age; }
            set {
                if (value > 0) {
                    _age = value;
                }
            }
        }

        public override bool Equals(object? obj) {
            return obj is Pessoa pessoa &&
                   Name == pessoa.Name &&
                   Phone == pessoa.Phone &&
                   _age == pessoa._age &&
                   Age == pessoa.Age;
        }


    }
}
