namespace PokemonEvolutionFinder.Models.EvolutionChain;

public class EvolutionChainRepository
{
    private HttpClient _client;

    public EvolutionChainRepository()
    {
        _client = new HttpClient();
    }

    public async Task<EvolutionChainRoot> GetEvolutionChainByUrl(string url)
    {
        return await _client.GetFromJsonAsync<EvolutionChainRoot>(url);
    }
}