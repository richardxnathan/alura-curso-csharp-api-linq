// Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.

List<int> numeros = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6, 7, 8, 9, 1 };

var numerosUnicos = numeros.Distinct();

Console.WriteLine("Números únicos na lista:");
foreach (var numero in numerosUnicos)
{
    Console.Write(numero + " ");
}
