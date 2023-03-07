namespace USCS
{
    public class TesteAluno
    {
        public static void Testar()
        {
            var x1 = new Aluno(55123, "Paulo", "800.912.345-12", 'M', 7.0, 6.0, 8.0);
            var x2 = new Aluno(991239, "Ana", "500.876.123-15", 'F', 2.0, 6.0, 9.0);


            Console.WriteLine("------- Aluno 1 -------");
            x1.ImprimeAluno();

            Console.WriteLine("------- Aluno 2 -------");
            x2.ImprimeAluno();
        }
    }
}
