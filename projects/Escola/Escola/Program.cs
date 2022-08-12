using Escola.Entities;
using Escola.Entities.Enums;

namespace Escola {

    public class Program {

        public static void Main(string[] args) {

            // upcasting: classe filha mencionada como classe mãe
            Pessoa jhon = new Student("Jhon", 19, Eletiva.SCIENCE);

            // downcasting: classe mãe se transformando em classe filha
            Student studentJhon = null;

            if(jhon is Student) {
                studentJhon = jhon as Student;
            } else {
                throw new ArgumentException();
            }

            studentJhon.MakeExam();

            Console.WriteLine($"Score = {studentJhon.Score}! Result: {studentJhon.IsApproved()}");

        }

    }

}