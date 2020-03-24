using Microsoft.Xna.Framework.Input;
using SadConsole.Components;
using SadConsole.Input;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace InkConsole
{
    class InkConsoleInput : KeyboardConsoleComponent
    {
        string input = "";
        private Action<string> ProcessInput = (s) => { int i = s.Length; };

        public override void ProcessKeyboard(SadConsole.Console console, SadConsole.Input.Keyboard info, out bool handled)
        {
            foreach (AsciiKey key in info.KeysPressed)
            {
                if (key.Character != '\0')
                {
                    input += key.Character.ToString();
                    console.Cursor.Print(key.Character.ToString());
                }
                if (key.Key == Keys.Back)
                {
                    if (input.Length > 0)
                    {
                        input = input.Remove(input.Length - 1, 1);
                        console.Cursor.LeftWrap(1).Print(" ").LeftWrap(1);
                    }
                }
                if (key.Key == Keys.Enter)
                {
                    ProcessInput(input);
                    input = "";
                }
            }
            handled = true;
        }

        public void SetProcess(Action<string> process)
        {
            input = "";
            this.ProcessInput = process;
        }
    }
}