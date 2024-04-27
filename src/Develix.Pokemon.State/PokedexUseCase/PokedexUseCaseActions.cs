namespace Develix.Pokemon.State.PokedexUseCase;

public record GetPokemonAction(int PokedexId);

public record GetPokemonResultAction(PokeApiNet.Pokemon Pokemon);
