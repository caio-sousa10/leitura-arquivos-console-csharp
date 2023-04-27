// 3) Arquivo "datas" extrair somente o ano e mostrar no console​

// instanciando objeto reader
TextReader reader = new StreamReader(@"C:\aula 6\datas.txt");

// criando variavel linha
String linha = reader.ReadLine();

// loop para ler o arquivo inteiro linha por linha
while (linha!= null)
{
    int posicao_barra1 = linha.IndexOf('/');
    string linha_printada = linha.Substring(posicao_barra1 + 4, 4);
    linha = reader.ReadLine() ;
    Console.WriteLine(linha_printada);
}