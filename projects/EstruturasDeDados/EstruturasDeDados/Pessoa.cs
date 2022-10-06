using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeDados {
    public class Pessoa {

        public string name { get; set; }
        public int age { get; set; }

        public Pessoa(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public override bool Equals(object? obj) {
            return obj is Pessoa pessoa &&
                   name == pessoa.name &&
                   age == pessoa.age;
        }

        public override int GetHashCode() {
            return HashCode.Combine(name, age);
        }
    }
}
