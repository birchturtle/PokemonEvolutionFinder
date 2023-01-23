using System.Text.Json.Serialization;

namespace PokemonEvolutionFinder.Models.Species;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Area
    { 
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Color
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class EggGroup
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class EvolutionChain
    {
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class FlavorTextEntry
    {
        [JsonPropertyName("flavor_text")]
        public string flavor_text { get; set; }

        [JsonPropertyName("language")]
        public Language language { get; set; }

        [JsonPropertyName("version")]
        public Version version { get; set; }
    }

    public class Genera
    {
        [JsonPropertyName("genus")]
        public string genus { get; set; }

        [JsonPropertyName("language")]
        public Language language { get; set; }
    }

    public class Generation
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class GrowthRate
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Habitat
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Language
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Name
    {
        [JsonPropertyName("language")]
        public Language language { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }
    }

    public class PalParkEncounter
    {
        [JsonPropertyName("area")]
        public Area area { get; set; }

        [JsonPropertyName("base_score")]
        public int base_score { get; set; }

        [JsonPropertyName("rate")]
        public int rate { get; set; }
    }

    public class Pokedex
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class PokedexNumber
    {
        [JsonPropertyName("entry_number")]
        public int entry_number { get; set; }

        [JsonPropertyName("pokedex")]
        public Pokedex pokedex { get; set; }
    }

    public class Pokemon
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class SpeciesRoot
    {
        [JsonPropertyName("base_happiness")]
        public int base_happiness { get; set; }

        [JsonPropertyName("capture_rate")]
        public int capture_rate { get; set; }

        [JsonPropertyName("color")]
        public Color color { get; set; }

        [JsonPropertyName("egg_groups")]
        public List<EggGroup> egg_groups { get; set; }

        [JsonPropertyName("evolution_chain")]
        public EvolutionChain evolution_chain { get; set; }

        [JsonPropertyName("evolves_from_species")]
        public object evolves_from_species { get; set; }

        [JsonPropertyName("flavor_text_entries")]
        public List<FlavorTextEntry> flavor_text_entries { get; set; }

        [JsonPropertyName("form_descriptions")]
        public List<object> form_descriptions { get; set; }

        [JsonPropertyName("forms_switchable")]
        public bool forms_switchable { get; set; }

        [JsonPropertyName("gender_rate")]
        public int gender_rate { get; set; }

        [JsonPropertyName("genera")]
        public List<Genera> genera { get; set; }

        [JsonPropertyName("generation")]
        public Generation generation { get; set; }

        [JsonPropertyName("growth_rate")]
        public GrowthRate growth_rate { get; set; }

        [JsonPropertyName("habitat")]
        public Habitat habitat { get; set; }

        [JsonPropertyName("has_gender_differences")]
        public bool has_gender_differences { get; set; }

        [JsonPropertyName("hatch_counter")]
        public int hatch_counter { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("is_baby")]
        public bool is_baby { get; set; }

        [JsonPropertyName("is_legendary")]
        public bool is_legendary { get; set; }

        [JsonPropertyName("is_mythical")]
        public bool is_mythical { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("names")]
        public List<Name> names { get; set; }

        [JsonPropertyName("order")]
        public int order { get; set; }

        [JsonPropertyName("pal_park_encounters")]
        public List<PalParkEncounter> pal_park_encounters { get; set; }

        [JsonPropertyName("pokedex_numbers")]
        public List<PokedexNumber> pokedex_numbers { get; set; }

        [JsonPropertyName("shape")]
        public Shape shape { get; set; }

        [JsonPropertyName("varieties")]
        public List<Variety> varieties { get; set; }
    }

    public class Shape
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Variety
    {
        [JsonPropertyName("is_default")]
        public bool is_default { get; set; }

        [JsonPropertyName("pokemon")]
        public Pokemon pokemon { get; set; }
    }

    public class Version
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

