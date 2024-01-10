// Escrever um programa que faça uma requisição para a API de games CheapShark e mostre na tela a
// lista de promoções cadastrada na ferramenta (Você pode utilizar o endpoint: https://www.cheapshark.com/api/1.0/deals).

using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
    Console.WriteLine(resposta);
}