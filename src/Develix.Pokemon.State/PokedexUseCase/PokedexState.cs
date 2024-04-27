namespace Develix.Pokemon.State.PokedexUseCase;

[FeatureState]
public record PokedexState
{
    public bool IsLoading { get; init; }
    public PokeApiNet.Pokemon? Pokemon { get; init; }
}
