using MudBlazor;

namespace Blazor.WASM.Styles
{
    public class Themes
    {
        public static MudTheme DefaultTheme => GetDefaultTheme();

        private static MudTheme GetDefaultTheme()
        {
            var mudTheme = new MudTheme()
            {
                PaletteLight = new PaletteLight()
                {
                    AppbarBackground = Colors.Shades.White,
                    Background = "#f2f5fa",
                    Primary = "#2162f7",
                    Secondary = Colors.LightBlue.Lighten5,
                    Tertiary = Colors.Purple.Lighten2,
                    Black = Colors.Shades.Black,
                    White = Colors.Shades.White


                },
                
                Typography = new Typography
                {
                    Default = new Default
                    {
                        FontFamily = ["Inter", "Helvetica", "Arial", "sans-serif"],
                    }
                }

            };
            PaletteDark darkPalette = new()
            {
                Primary = mudTheme.PaletteLight.Primary.ColorDarken(0.2f),
                Secondary = mudTheme.PaletteLight.Secondary.ColorDarken(0.2f),
                Background = mudTheme.PaletteLight.Background.ColorDarken(0.5f),
                AppbarBackground = mudTheme.PaletteLight.AppbarBackground.ColorDarken(0.3f),
                Black = Colors.Shades.Black,
                White = Colors.Shades.White
            };
            mudTheme.PaletteDark = darkPalette;
            return mudTheme;
        }
    }
}
