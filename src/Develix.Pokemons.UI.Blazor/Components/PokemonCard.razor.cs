using Microsoft.AspNetCore.Components;
using PokeApiNet;

namespace Develix.Pokemons.UI.Blazor.Components;

public partial class PokemonCard
{
    [Parameter]
    [EditorRequired]
    public Pokemon? Pokemon { get; set; }

    private string GetPokemonTypeNames(Pokemon pokemon)
    {
        var types = pokemon.Types.Select(t => t.Type.Name);
        return string.Join(", ", types);
    }
}
