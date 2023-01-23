using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using PokemonEvolutionFinder.Models;

namespace PokemonEvolutionFinder.Controllers;

[ApiController]
[Route("[controller]")]
public class EvolutionFinderController : ControllerBase
{

    [HttpGet("{name}")]
    public async Task<IEnumerable<String>> GetAsync(string name)
    {
        var builder = new EvolutionChainBuilder();

        return await builder.BuildEvolutionChainFromName(name);
    }
}