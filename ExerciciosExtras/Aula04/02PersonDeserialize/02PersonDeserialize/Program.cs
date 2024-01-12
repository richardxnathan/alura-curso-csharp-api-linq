// Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, desserializa essas informações e exibe na tela.

using _02PersonDeserialize;
using System.Text.Json;

string fileName = "pessoa.json";

if (File.Exists(fileName))
{
    string jsonString = File.ReadAllText(fileName);

    Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString);

    Console.WriteLine($"Nome: {pessoa.Nome}");
    Console.WriteLine($"Idade: {pessoa.Idade}");
    Console.WriteLine($"E-mail: {pessoa.Email}");
}
else
{
    Console.WriteLine($"O arquivo {fileName} não existe.");
}