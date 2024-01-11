﻿// Dadas duas listas de números, criar uma consulta LINQ para retornar uma lista que contenha apenas os números que estão presentes em ambas as listas.

List<int> lista1 = new List<int> { 1, 2, 3, 4, 5 };
List<int> lista2 = new List<int> { 3, 4, 5, 6, 7 };

var numerosComuns = lista1.Intersect(lista2);

Console.WriteLine("Números presentes em ambas as listas:");
foreach (var numero in numerosComuns)
{
    Console.Write(numero + " ");
}