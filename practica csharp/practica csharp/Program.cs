Console.WriteLine("Ingresa un palabra: ");
string palabra = Console.ReadLine();
char[] caracteres = palabra.ToCharArray();
Array.Reverse(caracteres);
Console.WriteLine(new string(caracteres));