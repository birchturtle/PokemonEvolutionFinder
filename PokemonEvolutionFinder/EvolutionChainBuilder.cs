using PokemonEvolutionFinder.Models.Pokemon;
using PokemonEvolutionFinder.Models.Species;
using PokemonEvolutionFinder.Models.EvolutionChain;
namespace PokemonEvolutionFinder;

public class EvolutionChainBuilder
{
    private readonly EvolutionRepository _pokemonRepository;
    private readonly SpeciesRepository _speciesRepository;
    private readonly EvolutionChainRepository _evolutionChainRepository;

    public EvolutionChainBuilder()
    {
        _pokemonRepository = new EvolutionRepository();
        _speciesRepository = new SpeciesRepository();
        _evolutionChainRepository = new EvolutionChainRepository();
    }

    public async Task<IEnumerable<string>> BuildEvolutionChainFromName(string name)
    {
        var pokemon = await _pokemonRepository.GetByName(name);
        var species = await _speciesRepository.GetEvolutionChainFromSpecies(pokemon.species.url);
        var evolutionChain = await _evolutionChainRepository.GetEvolutionChainByUrl(species.evolution_chain.url);

        var chain = new List<string>() { evolutionChain.chain.species.name };
        chain.AddRange(GetNamesFromEvolvesTo(evolutionChain.chain.evolves_to[0]));
        return chain;
    }

    private List<string> GetNamesFromEvolvesTo(EvolvesTo evolvesTo)
    {
        var names = new List<string>();
        names.Add(evolvesTo.species.name);
        if (evolvesTo.evolves_to.Count > 0)
        {
            names.AddRange(GetNamesFromEvolvesTo(evolvesTo.evolves_to[0]));    
        }
        return names;
    }
}