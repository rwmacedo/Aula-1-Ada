Console.WriteLine("Digite seu nome:");
var nome = Console.ReadLine();

Console.WriteLine($"Olá, ");
Console.WriteLine(nome);

Console.WriteLine("Digite a primeira nota:");
var nota1=Console.ReadLine();
Console.WriteLine("Digite a segunda nota:");
var nota2 = Console.ReadLine();
Console.WriteLine("Digite a terceira nota:");
var nota3 = Console.ReadLine();

var media = (Convert.ToInt32(nota1) + Convert.ToInt32(nota2)+Convert.ToInt32(nota3)) / 3;

Console.Write($"A média das notas é: ");
Console.Write(media);
