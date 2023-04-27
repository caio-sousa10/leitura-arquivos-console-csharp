// 1) Arquivo "nomes_telefones" para cada número de telefone, retirar os parenteses e traços e apresentar no console​

// instanciando objeto reader
TextReader reader = new StreamReader(@"C:\aula 6\nomes_telefones.txt");

// criando variavel linha
String linha = reader.ReadLine();

// loop para ler o arquivo inteiro linha por linha
while (linha != null)
{
    int posicao_parenteses1 = linha.IndexOf('(');
    int posicao_parenteses2 = linha.IndexOf(')');
    int posicao_traco = linha.IndexOf('-');
    string linha_printada = linha.Substring(posicao_parenteses1 + 1, 2);
    string linha_printada_meio = linha.Substring(posicao_parenteses2 + 1, 5);
    string linha_printada_final = linha.Substring(posicao_traco + 1, 4);
    Console.WriteLine(linha);
    linha = reader.ReadLine();
    Console.WriteLine(linha_printada + linha_printada_meio + linha_printada_final);
}
