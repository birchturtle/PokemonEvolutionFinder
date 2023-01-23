using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Win32;
using PokemonEvolutionFinder.Controllers;
using PokemonEvolutionFinder.Models;
using Xunit;

namespace PokemonEvolutionFinder.Tests;

public class EvolutionFinderTests
{
    public static IEnumerable<object> CollectionOfEvolutionChains()
    {
        yield return new object[] { new List<string> { "charmander", "charmeleon", "charizard" }, "charmander" };
        yield return new object[] { new List<string> { "squirtle", "wartortle", "blastoise" }, "squirtle" };
    }
    
    [Theory]
    [MemberData(nameof(CollectionOfEvolutionChains))]
    public async void ControllerReturnsEvolutionChainGivenPokemonName(IEnumerable<string> expected, string name)
    {
        var controller = new EvolutionFinderController();

        var result = await controller.GetAsync(name);
        
        Assert.Equal(expected, result);
    }
}