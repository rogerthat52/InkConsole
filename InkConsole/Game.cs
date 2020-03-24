using Microsoft.Xna.Framework;
using SadConsole;

namespace InkConsole
{
	class Game
	{
        private static Point resolution = new Point(80, 25);
        public static InkManager inkManager;

        static void Main()
        {
            //// Setup the engine and create the main window.
            SadConsole.Game.Create(resolution.X, resolution.Y);

            //// Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;

            //// Start the game.
            SadConsole.Game.Instance.Run();
            SadConsole.Game.Instance.Dispose();
        }


        static void Init()
        {
            // make console
            var console = new Console(resolution.X, resolution.Y);

            // set size to window
            Settings.ResizeMode = Settings.WindowResizeOptions.None;
            Settings.ResizeWindow(resolution.X * console.Font.Size.X, resolution.Y * console.Font.Size.Y);
            
            // attach console to ink manager and load script
            inkManager = new InkManager(console, "scripts/main.json");

            // enable console
            console.IsVisible = true;
            console.IsFocused = true;
            Global.CurrentScreen = console;
        }
    }

}
