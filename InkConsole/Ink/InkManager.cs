using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InkConsole.Console;
using Ink.Runtime;
using SadConsole;
using InkConsole.Combat;

namespace InkConsole.Prompts
{
    class InkManager
    {
        Console.Console Console;
        Story InkStory;

        public InkManager(Console.Console console, string fileName)
        {
            this.Console = console;
            LoadFile(fileName);
            Initalize();
        }

        private void LoadFile(string fileName)
        {
            InkStory = new Story(File.ReadAllText(fileName));
        }

        public void Initalize()
        {
            Console.SetProcess(ProcessInput);

            // start tree
            ContinueStory();
        }

        public bool NextLine()
        {
            string line = InkStory.Continue();
            if (line.Contains(">>>"))
            {

                Console.ClearText();
                List<BaseCharacter> enemies = new List<BaseCharacter>{ new Enemy(), new Enemy() };
                Debug.WriteLine(enemies.Count);
                Game.combatManager.OnSuccess = Initalize;
                Game.combatManager.Initalize(enemies);
                return false;
            }
            else
            {
                Console.PrintLine(line);
            }
            return true;
        }

        public void ContinueStory()
        {
            // clear the screen
            Console.ClearText();

            // draw story
            while (InkStory.canContinue)
            {
                // if NextLine returns false then it means that a fight was triggered
                if (!NextLine())
                {
                    break;
                }
                // uncomment out for spaces between sentences 
                //Console.NextLine();
            }
            Console.NextLine();

            if (!InkStory.canContinue && InkStory.currentChoices.Count == 0)
            {
                Timer exit = new Timer(TimeSpan.FromSeconds(1));
                exit.TimerElapsed += Exit_TimerElapsed;
                Console.Components.Add(exit);
                Console.PrintLine("Exiting in 1 second.");
                Debug.WriteLine("exiting");
            }
        }

        private void Exit_TimerElapsed(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        public void DisplayOptions()
        {
            Console.Print("\nOPTIONS:");
            foreach (var option in InkStory.currentChoices)
            {
                Console.Print(" " + option.text);
            }
            Console.NextLine();
        }

        public void ProcessInput(string input)
        {
            Debug.WriteLine(input);
            var guy = InkStory.currentChoices.Find(choice => choice.text.Equals(input, StringComparison.OrdinalIgnoreCase));
            if(guy != null)
            {
                InkStory.ChooseChoiceIndex(guy.index);
                ContinueStory();
            } else
            {
                Console.PrintLine("Invalid Input\n");
            }
        }
    }
}
