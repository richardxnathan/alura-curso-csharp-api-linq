// Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.

try
{
    List<int> listaDeNumeros = [1, 2, 3, 4];
    Console.WriteLine($"Elemento do indice 4: {listaDeNumeros[4]}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}