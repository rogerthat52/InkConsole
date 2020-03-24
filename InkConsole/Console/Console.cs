using System;
using Microsoft.Xna.Framework;

namespace InkConsole
{
    class Console : SadConsole.Console
    {
        public string Prompt { get; set; }
        private InkConsoleInput _keyboardInput;

        public Console(int x, int y)
            : base(x, y)
        {

            IsVisible = false;

            _keyboardInput = new InkConsoleInput();
            Components.Add(_keyboardInput);

            UseKeyboard = true;
            Cursor.IsVisible = true;

            ClearText();
        }

        public void ClearText()
        {
            Clear();
            Cursor.Position = new Point(0, 0);
        }
        public void PrintLine(string line)
        {
            Cursor.Print(line);
            Cursor.CarriageReturn();
        }

        public void Print(string text)
        {
            Cursor.Print(text);
        }

        public void NextLine()
        {
            Cursor.Move(Cursor.Position + new Point(0, 1));
            Cursor.CarriageReturn();
        }

        public virtual void SetProcess(Action<string> process)
        {
            _keyboardInput.SetProcess(process);
        }
    }
}
