namespace PokemonEvolutionFinder.Models.Pokemon;

public class EvolutionRepository
{
    private HttpClient _client;

    public EvolutionRepository(HttpClient client)
    {
        _client = client;
    }

    public async Task<PokemonRoot> GetByName(string name)
    {
        return await _client.GetFromJsonAsync<PokemonRoot>($"https://pokeapi.co/api/v2/pokemon/{name}");
    }
}