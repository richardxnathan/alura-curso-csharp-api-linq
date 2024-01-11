// Dada uma lista de livros com título, autor e ano de publicação,
// criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.

using _03BookList;

List<Livro> livros = new List<Livro>
{
    new Livro { Titulo = "Aprendendo LINQ", Autor = "João Silva", AnoPublicacao = 2005 },
    new Livro { Titulo = "Programação em C#", Autor = "Ana Oliveira", AnoPublicacao = 2010 },
    new Livro { Titulo = "Algoritmos e Estruturas de Dados", Autor = "Carlos Santos", AnoPublicacao = 1998 },
    new Livro { Titulo = "Introdução à Inteligência Artificial", Autor = "Mariana Costa", AnoPublicacao = 2021 },
    new Livro { Titulo = "Design Patterns", Autor = "Paulo Rocha", AnoPublicacao = 2002 }
};

var livrosSelecionados = livros.Where(livros => livros.AnoPublicacao > 2000).ToList().Select(livros => livros.Titulo).Order();

Console.WriteLine("Títulos de livros publicados após 2000, ordenados alfabeticamente:");
foreach (var livro in livrosSelecionados)
{
    Console.WriteLine($"- {livro}");
}
