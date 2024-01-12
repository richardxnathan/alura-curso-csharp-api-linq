// Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.

using _05PersonListDeserializeFilter;
using System.Text.Json;

string fileName = "pessoas.json";

if (File.Exists(fileName))
{
    string jsonString = File.ReadAllText(fileName);

    List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);

    Console.Write("Digite a idade para buscar pessoas: ");
    int idadeParaBuscar = int.Parse(Console.ReadLine());

    List<Pessoa> pessoasComIdade = pessoas.Where(p => p.Idade == idadeParaBuscar).ToList();

    if (pessoasComIdade.Any())
    {
        Console.WriteLine($"Pessoas com {idadeParaBuscar} anos:");

        foreach (Pessoa pessoa in pessoasComIdade)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, E-mail: {pessoa.Email}");
        }
    }
    else
    {
        Console.WriteLine($"Nenhuma pessoa encontrada com {idadeParaBuscar} anos.");
    }
}
else
{
    Console.WriteLine($"O arquivo {fileName} não existe.");
}
