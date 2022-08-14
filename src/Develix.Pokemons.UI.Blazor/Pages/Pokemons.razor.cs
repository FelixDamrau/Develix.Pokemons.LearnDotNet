﻿using Develix.Pokemons.State.PokedexUseCase;
using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Develix.Pokemons.UI.Blazor.Pages;

public partial class Pokemons
{
    private int pokedexId = 1;

    [Inject]
    private IDispatcher dispatcher { get; set; } = null!;

    [Inject]
    IState<PokedexState> pokedexState { get; set; } = null!;

    private void GetPokemon()
    {
        var action = new GetPokemonAction(pokedexId);
        dispatcher.Dispatch(action);
    }

    private void KeyPressedInInputField(KeyboardEventArgs e)
    {
        if (e.Key == "Enter" && !GetPokemonDisabled())
            GetPokemon();
    }

    private bool GetPokemonDisabled() => pokedexState.Value.IsLoading;
}
