// Neste link, existe uma série de APIs públicas e seu desafio é realizar uma requisição e exibir os dados no console.
// https://github.com/public-apis/public-apis

using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://api.thecatapi.com/v1/images/search");
    Console.WriteLine(resposta);
}
