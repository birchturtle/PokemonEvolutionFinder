﻿using System.Net;

namespace PokemonEvolutionFinder.Models.Species;

public class SpeciesRepository
{
    private HttpClient _client;

    public SpeciesRepository(HttpClient client)
    {
        _client = client;
    }

    public async Task<Root> GetEvolutionChainFromSpecies(string speciesUrl)
    {
        return await _client.GetFromJsonAsync<Root>(speciesUrl);
    }
}