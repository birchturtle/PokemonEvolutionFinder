namespace PokemonEvolutionFinder.Controllers;

public interface IEvolutionChainBuilder
{
    Task<IEnumerable<string>> BuildEvolutionChainFromName(string name);
}