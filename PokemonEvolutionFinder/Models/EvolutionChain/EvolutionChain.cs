using System.Text.Json.Serialization;

namespace PokemonEvolutionFinder.Models.EvolutionChain;

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Chain
    {
        [JsonPropertyName("evolution_details")]
        public List<object> evolution_details { get; set; }

        [JsonPropertyName("evolves_to")]
        public List<EvolvesTo> evolves_to { get; set; }

        [JsonPropertyName("is_baby")]
        public bool is_baby { get; set; }

        [JsonPropertyName("species")]
        public Species species { get; set; }
    }

    public class EvolutionDetail
    {
        [JsonPropertyName("gender")]
        public object gender { get; set; }

        [JsonPropertyName("held_item")]
        public object held_item { get; set; }

        [JsonPropertyName("item")]
        public object item { get; set; }

        [JsonPropertyName("known_move")]
        public object known_move { get; set; }

        [JsonPropertyName("known_move_type")]
        public object known_move_type { get; set; }

        [JsonPropertyName("location")]
        public object location { get; set; }

        [JsonPropertyName("min_affection")]
        public object min_affection { get; set; }

        [JsonPropertyName("min_beauty")]
        public object min_beauty { get; set; }

        [JsonPropertyName("min_happiness")]
        public object min_happiness { get; set; }

        [JsonPropertyName("min_level")]
        public int min_level { get; set; }

        [JsonPropertyName("needs_overworld_rain")]
        public bool needs_overworld_rain { get; set; }

        [JsonPropertyName("party_species")]
        public object party_species { get; set; }

        [JsonPropertyName("party_type")]
        public object party_type { get; set; }

        [JsonPropertyName("relative_physical_stats")]
        public object relative_physical_stats { get; set; }

        [JsonPropertyName("time_of_day")]
        public string time_of_day { get; set; }

        [JsonPropertyName("trade_species")]
        public object trade_species { get; set; }

        [JsonPropertyName("trigger")]
        public Trigger trigger { get; set; }

        [JsonPropertyName("turn_upside_down")]
        public bool turn_upside_down { get; set; }
    }

    public class EvolvesTo
    {
        [JsonPropertyName("evolution_details")]
        public List<EvolutionDetail> evolution_details { get; set; }

        [JsonPropertyName("evolves_to")]
        public List<EvolvesTo> evolves_to { get; set; }

        [JsonPropertyName("is_baby")]
        public bool is_baby { get; set; }

        [JsonPropertyName("species")]
        public Species species { get; set; }
    }

    public class EvolutionChainRoot
    {
        [JsonPropertyName("baby_trigger_item")]
        public object baby_trigger_item { get; set; }

        [JsonPropertyName("chain")]
        public Chain chain { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }
    }

    public class Species
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Trigger
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

