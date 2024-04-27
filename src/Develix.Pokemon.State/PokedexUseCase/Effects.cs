using PokeApiNet;

namespace Develix.Pokemon.State.PokedexUseCase;

public class Effects(PokeApiClient pokeApiClient)
{
    private readonly PokeApiClient pokeApiClient = pokeApiClient;

    [EffectMethod]
    public async Task HandleGetPokemonAction(GetPokemonAction action, IDispatcher dispatcher)
    {
        var pokemon = await pokeApiClient.GetResourceAsync<PokeApiNet.Pokemon>(action.PokedexId);
        var resultAction = new GetPokemonResultAction(pokemon);
        dispatcher.Dispatch(resultAction);
    }
}
