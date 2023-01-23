using PokemonEvolutionFinder.Models.Species;

namespace PokemonEvolutionFinder.Tests;

public class SpeciesRepositoryTests
{
    [Fact]
    public async void RepositoryCanGetEvolutionChainUrl()
    {
        var repository = new SpeciesRepository();

        var evolutionChainFromSpecies = await repository.GetEvolutionChainFromSpecies("https://pokeapi.co/api/v2/pokemon-species/4/");

        Assert.Equal("https://pokeapi.co/api/v2/evolution-chain/2/", evolutionChainFromSpecies.evolution_chain.url);
    }
}