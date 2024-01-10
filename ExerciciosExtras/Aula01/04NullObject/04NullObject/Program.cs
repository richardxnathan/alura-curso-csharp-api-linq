// Criar uma classe simples com um método e chame esse método em um objeto nulo. Tratar a exceção de método em objeto nulo.

using _04NullObject;




using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://anapioficeandfire.com/api/characters/583");
    Console.WriteLine(resposta);
}
