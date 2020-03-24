using System;
using System.Collections.Generic;
using System.Diagnostics;
using InkConsole.Console;

namespace InkConsole.Combat
{
    class CombatManager
    {
        Console.Console Console;
        public Action OnSuccess;

        William williamWorm;
        List<BaseCharacter> enemies;

        public CombatManager(Console.Console console)
        {
            this.Console = console;
        }

        public void Initalize(List<BaseCharacter> enemies)
        {
            this.williamWorm = new William();
            this.enemies = enemies;
            Console.ClearText();
            StartFight();
        }

        public void StartFight()
        {
            // while william is alive and there are enemies left, repeat the loop
                WilliamTurn();
                EnemiesTurn();
        }

        private void WilliamTurn()
        {
            Console.ClearText();
            Debug.WriteLine("seth");
            Console.PrintLine("There are Two! Bugs in front of you. What do you do?\n");
            Console.PrintLine("William Worm HP:" + williamWorm.HP + "/100     Enemy 1 HP:" + enemies[0].HP + "/50     Enemy 2 HP:" + enemies[1].HP + "/50\n");
            Console.PrintLine("A.Attack    B.Ability   C.Items\n");
        }
        private void EnemiesTurn()
        {

        }
    }
}
