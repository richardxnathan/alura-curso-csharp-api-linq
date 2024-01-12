// Criar um programa que permite ao usuário inserir informações de uma pessoa (nome, idade, e e-mail),
// serializa essas informações em formato JSON e salva em um arquivo.

using _01Person;

Pessoa pessoa = new();
Console.Write("Digite o nome: ");
pessoa.Nome = Console.ReadLine();
Console.Write("Digite a idade: ");
pessoa.Idade = int.Parse(Console.ReadLine());
Console.Write("Digite o e-mail: ");
pessoa.Email = Console.ReadLine();

pessoa.GerarJson();