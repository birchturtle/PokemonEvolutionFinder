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

    private HttpClient client;

    public EvolutionFinderController()
    {
        client = new HttpClient();
    }

    [HttpGet("{name}")]
    public async Task<IEnumerable<String>> GetAsync(string name)
    {
        return EvolutionTree;
    }
}