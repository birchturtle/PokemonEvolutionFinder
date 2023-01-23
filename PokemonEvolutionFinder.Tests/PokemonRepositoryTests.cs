using System.Net.Http.Json;
using PokemonEvolutionFinder.Models.Pokemon;

namespace PokemonEvolutionFinder.Tests;

public class EvolutionRepositoryTests
{
    [Fact]
    public async void RepositoryCanGetSpeciesUrlByPokemonName()
    {
        string name = "charmander";
        var repository = new EvolutionRepository();

        var pokemon = await repository.GetByName(name);
        //var evolutions = await client.GetFromJsonAsync<SpeciesDto>(pokemon.Species.url);
        
        Assert.Equal("https://pokeapi.co/api/v2/pokemon-species/4/", pokemon.species.url);
    }
}