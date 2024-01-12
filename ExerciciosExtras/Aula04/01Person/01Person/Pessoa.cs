using System.Text.Json;

namespace _01Person;

internal class Pessoa
{

    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public Pessoa(string nome, int idade, string email) 
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }

    public Pessoa()
    {
    }

    public void GerarJson()
    {
        var json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            idade = Idade,
            email = Email
        });

        string nomeDoArquivo = "pessoa.json";

        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine("O arquivo foi criado com sucesso!");
    }

}
