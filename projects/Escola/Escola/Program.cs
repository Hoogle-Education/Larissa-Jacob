using Escola.Entities;

namespace Escola {

    public class Program {

        public static void Main(string[] args) {

            Student jhon = new Student("Jhon", 19);
            jhon.makeExam();

            Student maria = new Student("Maria", 18, "2019219821");
            maria.makeExam();

            jhon.Score = 2.4;

            Console.WriteLine($"Score = {jhon.Score}! Result: {jhon.IsApproved()}");

        }

    }

}