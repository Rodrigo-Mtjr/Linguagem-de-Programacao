namespace Interface_IComparable.Entidades
{
    class Funcionarios : IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; } 

        public Funcionarios(string csvFuncionario)
        {
            string[] vetor = csvFuncionario.Split(',');
            Nome = vetor[0];
            Salario = double.Parse(vetor[1]);
        }

        public override string ToString()
        {
            return Nome + "," + Salario.ToString("f2");
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Funcionarios))
            {
                throw new ArgumentException("Erro de comparação: o argumento não é um funcionário");
            }

            //Depois de verificar se o obj é do tipo funcionários, ele vai transformar então o obj em Funcionario.
            //Se a conversão der certo, a variavel OUTRO será do tipo FUNCIONARIOS.
            Funcionarios outro = obj as Funcionarios;

            //Comparando o Nome atual com o Nome da variavel OUTRO, pra ver qual vai ser primeiro na listagem.
            return Nome.CompareTo(outro.Nome);
        }
    }
}
