using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Ink.Runtime;
using SadConsole;

namespace InkConsole
{
    class InkManager
    {
        Console console;
        Story inkStory;

        Dictionary<string, Action> customCommands;

        public InkManager(Console console, string fileName)
        {
            this.console = console;
            customCommands = new Dictionary<string, Action>();
            LoadFile(fileName);
            Initalize();
        }

        private void LoadFile(string fileName)
        {
            inkStory = new Story(File.ReadAllText(fileName));
        }

        public void Initalize()
        {
            console.SetProcess(ProcessInput);

            // start tree
            ContinueStory();
        }

        public bool NextLine()
        {
            string line = inkStory.Continue();
            if (line.Contains(">>>"))
            {
                foreach (KeyValuePair<string, Action> command in customCommands)
                {
                    if (line.EndsWith(command.Key))
                    {
                        command.Value();
                    }
                }
            }
            else
            {
                console.PrintLine(line);
                return false;
            }
            return true;
        }

        public void ContinueStory()
        {
            // clear the screen
            console.ClearText();

            // draw story
            while (inkStory.canContinue)
            {
                // if NextLine returns false then it means that a command was triggered
                if (!NextLine())
                {
                    break;
                }
                // uncomment out for spaces between sentences 
                //Console.NextLine();
            }
            console.NextLine();

            if (!inkStory.canContinue && inkStory.currentChoices.Count == 0)
            {
                Timer exit = new Timer(TimeSpan.FromSeconds(1));
                exit.TimerElapsed += Exit_TimerElapsed;
                console.Components.Add(exit);
                console.PrintLine("Exiting in 1 second.");
                Debug.WriteLine("exiting");
            }
        }

        private void Exit_TimerElapsed(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        public void DisplayOptions()
        {
            console.Print("\nOPTIONS:");
            foreach (var option in inkStory.currentChoices)
            {
                console.Print(" " + option.text);
            }
            console.NextLine();
        }

        public void ProcessInput(string input)
        {
            Debug.WriteLine(input);
            var guy = inkStory.currentChoices.Find(choice => choice.text.Equals(input, StringComparison.OrdinalIgnoreCase));
            if(guy != null)
            {
                inkStory.ChooseChoiceIndex(guy.index);
                ContinueStory();
            } else
            {
                console.PrintLine("Invalid Input\n");
            }
        }
    }
}
