namespace PokemonEvolutionFinder.Models.EvolutionChain;

public class EvolutionChainRepository
{
    private HttpClient _client;

    public EvolutionChainRepository(HttpClient client)
    {
        _client = client;
    }

    public async Task<EvolutionChainRoot> GetEvolutionChainByUrl(string url)
    {
        return await _client.GetFromJsonAsync<EvolutionChainRoot>(url);
    }
}