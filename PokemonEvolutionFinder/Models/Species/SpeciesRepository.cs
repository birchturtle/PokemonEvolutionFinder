using System.Net;

namespace PokemonEvolutionFinder.Models.Species;

public class SpeciesRepository
{
    private HttpClient _client;

    public SpeciesRepository()
    {
        _client = new HttpClient();
    }

    public async Task<SpeciesRoot> GetEvolutionChainFromSpecies(string speciesUrl)
    {
        return await _client.GetFromJsonAsync<SpeciesRoot>(speciesUrl);
    }
}