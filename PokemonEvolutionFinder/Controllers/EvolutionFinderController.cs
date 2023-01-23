using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using PokemonEvolutionFinder.Models;

namespace PokemonEvolutionFinder.Controllers;

[ApiController]
[Route("[controller]")]
public class EvolutionFinderController : ControllerBase
{
    private readonly IEvolutionChainBuilder _builder;

    public EvolutionFinderController(IEvolutionChainBuilder builder)
    {
        _builder = builder;
    }

    [HttpGet("{name}")]
    public async Task<IEnumerable<String>> GetAsync(string name)
    {
        return await _builder.BuildEvolutionChainFromName(name);
    }
}