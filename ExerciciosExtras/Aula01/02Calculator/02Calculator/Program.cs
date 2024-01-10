// Escrever um programa que solicite dois números a e b lidos do teclado e realize a divisão de a por b.
// Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.

try
{
    Console.Write("Informe um número: ");
    string numeroStringado = Console.ReadLine()!;
    int a = Convert.ToInt32(numeroStringado);

    Console.Write("Informe outro número: ");
    string numeroStringado2 = Console.ReadLine()!;
    int b = Convert.ToInt32(numeroStringado2);

    Console.WriteLine($"\nA divisão do {a} por {b} é {a / b}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Erro: na matemática não é permitida a divisão por 0.");
}