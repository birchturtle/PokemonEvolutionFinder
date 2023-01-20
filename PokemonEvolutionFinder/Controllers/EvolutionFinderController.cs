using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using PokemonEvolutionFinder.Models;

namespace PokemonEvolutionFinder.Controllers;

[ApiController]
[Route("[controller]")]
public class EvolutionFinderController : ControllerBase
{
    private static readonly string[] EvolutionTree = new[]
    {
        "Charmander", "Charmeleon", "Charizard"
    };

    public EvolutionFinderController()
    {
    }

    [HttpGet("{name}")]
    public IEnumerable<String> Get(string name)
    {
        return EvolutionTree;
    }
}