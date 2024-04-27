using Microsoft.AspNetCore.Components;

namespace Develix.Pokemon.UI.Blazor.Components;

public partial class PokemonCard
{
    [Parameter]
    [EditorRequired]
    public PokeApiNet.Pokemon? Pokemon { get; set; }

    private string GetPokemonTypeNames(PokeApiNet.Pokemon pokemon)
    {
        var types = pokemon.Types.Select(t => t.Type.Name);
        return string.Join(", ", types);
    }
}
