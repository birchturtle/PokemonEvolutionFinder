using PokemonEvolutionFinder.Models.EvolutionChain;

namespace PokemonEvolutionFinder.Tests;

public class EvolutionChainRepositoryTests
{
    [Fact]
    public async void RepositoryCanGetEvolvesTo()
    {
        string chainUrl = "https://pokeapi.co/api/v2/evolution-chain/2/";
        List<string> expected = new List<string>() { "charmander", "charmeleon", "Charizard" };
        var repository = new EvolutionChainRepository(new HttpClient());

        var evolutionChain = await repository.GetEvolutionChainByUrl(chainUrl);

        Assert.Equal(expected[1], evolutionChain.chain.evolves_to[0].species.name);
    }
}