// 5) Arquivo “produtos_estoque” mostrar o valor total de itens em estoque e o valor total em $.​

// instanciando objeto reader
TextReader reader = new StreamReader(@"C:\aula 6\produtos_estoque.txt");

// criando variavel linha
String linha = reader.ReadLine();

// inicializando variaveis
double soma_valor = 0.00;
int soma_estoque = 0;

// loop para ler o arquivo inteiro linha por linha
while (linha != null)
{
    int posicao_barra = linha.IndexOf('|');
    int estoque = Convert.ToInt32(linha.Substring(posicao_barra + 1));
    soma_estoque += estoque;
    int posicao_dinheiro = linha.IndexOf('$');
    double valor = Convert.ToDouble(linha.Substring(posicao_dinheiro + 1, 3));
    soma_valor += valor;
    linha = reader.ReadLine();
}

// printando resultados
Console.WriteLine("Valor Total: $" + soma_valor);
Console.WriteLine("Estoque Total: " + soma_estoque);