// Criar um programa que permite ao usuário inserir informações de várias pessoas, armazena essas informações em uma lista, serializa a lista em formato JSON e salva em um arquivo.

using _03PersonListSerialize;
using System.Text.Json;

List<Pessoa> pessoas = [];

while (true)
{
    Pessoa pessoa = new Pessoa();
    Console.Write("Digite o nome (ou 'sair' para encerrar): ");
    string nome = Console.ReadLine();

    if (nome.ToLower() == "sair")
    {
        break;
    }
        
    pessoa.Nome = nome;

    Console.Write("Digite a idade: ");
    pessoa.Idade = int.Parse(Console.ReadLine());

    Console.Write("Digite o e-mail: ");
    pessoa.Email = Console.ReadLine();

    pessoas.Add(pessoa);
}

string jsonString = JsonSerializer.Serialize(pessoas);

string fileName = "pessoas.json";

File.WriteAllText(fileName, jsonString);

Console.WriteLine($"Os dados foram salvos em {fileName}.");
