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
                    Primary = Colors.Blue.Accent4,
                    Secondary = Colors.LightBlue.Lighten5,
                    Tertiary = Colors.Purple.Lighten2,
                    Black = Colors.Shades.Black,
                    White = Colors.Shades.White


                },
                PaletteDark = new PaletteDark()
                {
                    Primary = Colors.Green.Accent1,
                    Secondary = Colors.Red.Accent2
                },
                Typography = new Typography
                {
                    Default = new Default
                    {
                        FontFamily = ["NunitoSans", "Helvetica", "Arial", "sans-serif"],
                    }
                }

            };
            return mudTheme;
        }
    }
}
