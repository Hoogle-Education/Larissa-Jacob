namespace EstruturasDeDados {

    public class Program {

        public static void Main() {

            HashSet<Pessoa> list = new HashSet<Pessoa>();

            Pessoa p1 = new Pessoa("joao", 20);
            Pessoa p2 = new Pessoa("joao", 20);

            list.Add(p1);
            list.Add(p2);

            Pessoa p;
            if (!list.TryGetValue(p1, out p)) {
                Console.WriteLine("value doesn't exist");
            } else {
                Console.WriteLine(p);
            }

            list.RemoveWhere(p => p.age >= 20);

            Console.WriteLine(list.Count) ;



            Dictionary<string, int> idades = new Dictionary<string, int>();

            idades.Add(p1.name, p1.age);

            idades["joao"] = 21;

            foreach( KeyValuePair<string, int> pessoa in idades ) {
                Console.WriteLine($"{pessoa.Key} = {pessoa.Value}");
            }

            Console.WriteLine(idades["joao"]);

        }
    }

}