// 4) Arquivo "marcas_carros" extrair somente as marcas e apresentar no console​

// instanciando objeto reader
TextReader reader = new StreamReader(@"C:\aula 6\marcas_carros.txt");

// criando variavel linha
String linha = reader.ReadLine();

// loop para ler o arquivo inteiro linha por linha
while (linha != null)
{
    string[] partes_divididas= linha.Split('\t');
    string marca = partes_divididas[0].Trim();
    linha = reader.ReadLine();
    Console.WriteLine(marca);
}