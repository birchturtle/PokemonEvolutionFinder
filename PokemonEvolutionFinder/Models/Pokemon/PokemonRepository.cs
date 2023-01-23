namespace PokemonEvolutionFinder.Models.Pokemon;

public class EvolutionRepository
{
    private HttpClient _client;

    public EvolutionRepository(HttpClient client)
    {
        _client = client;
    }

    public async Task<Root> GetByName(string name)
    {
        return await _client.GetFromJsonAsync<Root>($"https://pokeapi.co/api/v2/pokemon/{name}");
    }
}