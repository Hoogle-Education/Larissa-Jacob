using Escola.Entities;

namespace Escola.Services {
    public class SchoolService {

        public List<Student> Students;
        public List<Employee> Employees;
        public List<Pessoa> Pessoas;

        public SchoolService() {
            Students = new List<Student>();
            Employees = new List<Employee>();
            Pessoas = new List<Pessoa>();
        }

        public void addStudent(Student student) {
            Students.Add(student);
            Pessoas.Add(student);
        }

        public void addEmployee(Employee employee) { 
            Employees.Add(employee);
            Pessoas.Add(employee);
        }

        public void Sort( Predicate<?> predicate ) {

        }

    }
}
