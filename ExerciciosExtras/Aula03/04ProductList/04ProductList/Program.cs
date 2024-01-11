// Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos.

using _04ProductList;

List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Laptop", Preco = 1200 },
            new Produto { Nome = "Smartphone", Preco = 800 },
            new Produto { Nome = "Tablet", Preco = 500 },
            new Produto { Nome = "Câmera", Preco = 300 }
        };

var precoMedio = produtos.Average(produtos => produtos.Preco);

Console.WriteLine("Preço médio dos produtos: " + precoMedio);
