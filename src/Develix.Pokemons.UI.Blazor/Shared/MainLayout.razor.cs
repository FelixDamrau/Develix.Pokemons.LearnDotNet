namespace Develix.Pokemons.UI.Blazor.Shared;

public partial class MainLayout
{
    private bool drawerOpen = true;

    private void DrawerToggle()
    {
        drawerOpen = !drawerOpen;
    }
}
