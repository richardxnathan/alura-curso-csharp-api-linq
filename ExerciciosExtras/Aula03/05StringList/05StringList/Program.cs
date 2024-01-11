// Dada uma lista de strings, criar uma consulta LINQ para ordenar as palavras por comprimento e retornar apenas aquelas que têm mais de 3 caracteres.

List<string> palavras = new List<string> { "cachorro", "gato", "elefante", "leão", "cobra" };

var palavrasOrdenadas = palavras.Where(palavras => palavras.Length > 3).ToList().OrderBy(palavras => palavras.Length);

Console.WriteLine("Palavras com mais de 3 caracteres, ordenadas por comprimento:");
foreach (var palavra in palavrasOrdenadas)
{
    Console.Write(palavra + " ");
}
