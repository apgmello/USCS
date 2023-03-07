namespace USCS
{
    public class Aluno
    {
        public int CodMat { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public char Sexo { get; set; }
        public double NotaP1 { get; set; }
        public double NotaP2 { get; set; }
        public double NotaP3 { get; set; }


        public Aluno(int codMat, string nome, string cpf, Char sexo, double notaP1, double notaP2, double notaP3)
        {
            CodMat = codMat;
            Nome = nome;
            CPF = cpf;
            Sexo = sexo;
            NotaP1 = notaP1;
            NotaP2 = notaP2;
            NotaP3 = notaP3;
        }

        public void ImprimeAluno()
        {
            Console.WriteLine($"Código do aluno: {CodMat}");
            ImprimeSexo();
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Nota 01: {NotaP1}");
            Console.WriteLine($"Nota 02: {NotaP2}");
            Console.WriteLine($"Nota 03: {NotaP3}");
            Console.WriteLine($"Média {MediaAluno()} ==> Aluno {Resultado()}");
        }

        public void ImprimeSexo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Sexo: {(Sexo == 'F' ? "Feminino" : "Masculino")}");
        }

        public double MediaAluno()
        {
            double menorNota = Math.Min(Math.Min(NotaP1, NotaP2), NotaP3);
            double media = (NotaP1 + NotaP2 + NotaP3 - menorNota) / 2;
            return media;
        }

        public string Resultado()
        {
            var media = MediaAluno();
            return media >= 6 ? "Aprovado" : "Reprovado";
        }
    }
}
