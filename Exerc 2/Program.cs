// 2) Arquivo "nomes_telefones" para cada nome de pessoa, verificar os maiores de 12 caracteres e
// apresentar na tela os mesmos em UpperCase

// instanciando objeto reader
TextReader reader = new StreamReader(@"C:\aula 6\nomes_telefones.txt");

// criando variavel linha
String linha = reader.ReadLine();

// loop para ler o arquivo inteiro linha por linha
while (linha != null)
{
    string[] partes_divididas = linha.Split(' ');
    string nome = partes_divididas[0].Trim();
    nome += " " + partes_divididas[1];
    linha = reader.ReadLine();
    if (nome.Length > 12)
    {
        Console.WriteLine(nome.ToUpper());
    }
}
