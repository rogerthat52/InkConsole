using System;
using Microsoft.Xna.Framework;
using SadConsole;
using InkConsole.Combat;
using InkConsole.Console;
using InkConsole.Prompts;

namespace InkConsole
{
	class Game
	{
        public static Point res = new Point(677, 343);
        public static InkManager inkManager;
        public static CombatManager combatManager;

  //      public static int roomNumber = 0;
		//public static int enemiesInRoom = 0;
		//public static string input;
		//public static int enemyHP1;
		//public static int enemyHP2;
  //      public static int inputnum;
  //      public static int turnCounter = 1;
  //      public static Random rand = new Random();
  //      public static bool mailBombPlanted = false;
  //      public static int turnsMailBombPlanted = 0;
  //      public static bool hasDiedYet = true;
  //      public static bool hasDiedYet1 = true;                                                                               
  //      public static void startGame()
		//{

  //          System.Console.Clear();
  //          System.Console.WriteLine("George W. Bug is dead. You are William Worm, stuck in the middle of Bug York.");
  //          System.Console.WriteLine("");
  //          System.Console.WriteLine("You are currently in the hospital with secret service swarming you. You must survive.");
  //          System.Console.WriteLine("");
  //          System.Console.WriteLine("There is a hallway that leads out of the room and goes left or right. What do you do?");
  //          System.Console.WriteLine("");
  //          input = System.Console.ReadLine();

		//	switch (input.ToLower())
		//	{
		//		case "piss":
  //                  System.Console.WriteLine("You piss on George W. Bug's body. That will teach your dad.");
  //                  System.Console.ReadKey();
		//			startGame();
		//			break;
		//		case "left":
  //                  System.Console.WriteLine("left");
		//			leftDirection1(0);
		//			break;
		//		case "right":
  //                  System.Console.WriteLine("right");
		//			break;
		//		case "items": 
		//		case "item":
		//			foreach (string item in William.items)
		//			{
  //                      System.Console.WriteLine(item);
		//			}
  //                  System.Console.ReadKey();
		//			startGame();
		//			break;

		//		default:
  //                  System.Console.WriteLine("Not valid");
  //                  System.Console.ReadKey();
		//			startGame();
		//			break;
		//	}

		//}
		//public static void leftDirection1(int timesVisited)
		//{
  //          System.Console.Clear();

		//	if (timesVisited == 0)
		//	{
		//		enemiesInRoom = 2;
  //              System.Console.WriteLine("Two Bugs appear in front of you! Prepare to fight!");
  //              System.Console.ReadKey();
		//		combatInstance(1);

		//	}
		//	else
		//	{
  //              System.Console.Clear();
  //              System.Console.WriteLine("You come along a hallway that is going out to the right. Along the wall to your left is a door that is cracked slightly ajar. Which way do you go? ");
  //              System.Console.WriteLine("");
  //              System.Console.WriteLine("A.Forward   B.Into the Right Hallway   C.Check Out the door   D.Go back to the starting room");
  //              input = System.Console.ReadLine();
  //              switch (input.ToLower())
  //              {
  //                  case "a":
                     
  //                      break;

  //              }
		//	}


		//}
  //      public static void rightDirection1()
  //      {
  //          System.Console.Clear();
  //          System.Console.WriteLine("You see a sign that says Floor 3 and arrive at an intersection of two hallways. Which way fo you go? ");
  //          System.Console.WriteLine("");
  //          System.Console.WriteLine("A.The hall continuing straight   B.");
  //      }
		//public static void georgeBugsRoom()
		//{

  //          System.Console.WriteLine("This is the room you started in");
  //          System.Console.WriteLine("There is a hallway that leads out of the rooms and goes left or right. What do you do?");
  //          System.Console.WriteLine("");
  //          System.Console.WriteLine("A.Left   B.Right");
  //          input = System.Console.ReadLine();
		//	switch (input.ToLower())
		//	{
		//		case "piss":
  //                  System.Console.WriteLine("You piss on George W. Bug's body. That will teach your dad.");
  //                  System.Console.ReadKey();
		//			startGame();
		//			break;
		//		case "a":
  //                  System.Console.WriteLine("left");
		//			leftDirection1(1);
		//			break;
		//		case "b":
  //                  System.Console.WriteLine("right");
  //                  rightDirection1();
		//			break;
		//		default:
  //                  System.Console.WriteLine("Not valid");
  //                  System.Console.ReadKey();
		//			startGame();
		//			break;
		//	}

		//}

		//public static void combatInstance(int enemyFightNumber)
		//{
		//	switch (enemyFightNumber)
		//	{
		//		case 1:
		//			roomNumber = 1;
		//			enemyHP1 = 50;
		//			enemyHP2 = 50;
		//			fightTime();
		//			break;
		//		default:
  //                  System.Console.WriteLine("I haven't made this part yet");
		//			break;
		//	}
		//}

		//public static void fightTime()
		//{
  //          turnCounter = 1;
  //          System.Console.Clear();
		//	switch (roomNumber)
  //          {
  //              case 1:
                    

  //                  for (; ; turnCounter++)
  //                  {

  //                      System.Console.Clear();
  //                      if (turnCounter % 2 == 1)
  //                      {
  //                          if (enemyHP1 > 0 && enemyHP2 > 0)
  //                          {
  //                              System.Console.WriteLine("There are Two! Bugs in front of you. What do you do?");
  //                              System.Console.WriteLine("");
  //                              System.Console.WriteLine("William Worm HP:" + William.health + "/100     Enemy 1 HP:" + enemyHP1 + "/50     Enemy 2 HP:" + enemyHP2 + "/50");
  //                              System.Console.WriteLine("");
  //                              System.Console.WriteLine("A.Attack    B.Ability   C.Items");
  //                              input = System.Console.ReadLine();
  //                              switch (input.ToUpper())
  //                              {
  //                                  case "A":

  //                                      System.Console.Clear();
  //                                      System.Console.WriteLine("What Bug do you attack ");
  //                                      System.Console.WriteLine("");
  //                                      System.Console.WriteLine("A.Bug Two   B.Bug One");
  //                                      input = System.Console.ReadLine();
  //                                      switch (input.ToUpper())
  //                                      {
  //                                          case "A":

  //                                              int damage = rand.Next(5, 8);
  //                                              enemyHP2 = enemyHP2 - damage;
  //                                              System.Console.WriteLine("You Have done " + damage + " points of damage");
  //                                              System.Console.ReadKey();
  //                                              if (enemyHP2 <= 0 && hasDiedYet  == true)
  //                                              {
  //                                                  System.Console.WriteLine("You have killed Bug Two!");
  //                                                  System.Console.ReadKey();
  //                                                  hasDiedYet = false;

  //                                              }
  //                                              else
  //                                              {
  //                                                  System.Console.Clear();
  //                                              }

                                                    
  //                                              break;
  //                                          case "B":
  //                                              int damage1 = rand.Next(5, 8);
  //                                              enemyHP1 = enemyHP1 - damage1;
  //                                              System.Console.WriteLine("You Have done " + damage1 + " points of damage");
  //                                              System.Console.ReadKey();
  //                                              break;
  //                                          default:
  //                                              turnCounter = 0;
  //                                              System.Console.WriteLine("Not a valid input, you fucking idiot");
  //                                              System.Console.ReadKey();
  //                                              break;
  //                                      }
  //                                      break;
  //                                  case "B":

  //                                      System.Console.Clear();
  //                                      System.Console.WriteLine("Choose an ability");
  //                                      System.Console.WriteLine("");
  //                                      System.Console.WriteLine("A.The Dash   B.Gun   C.Mail Bomb   D.I dont fucking know   E.Go Back");
  //                                      input = System.Console.ReadLine();
  //                                      switch (input.ToUpper())
  //                                      {
  //                                          case "A":
  //                                              int damagetail = rand.Next(3, 10);
  //                                              System.Console.Clear();
  //                                              enemyHP1 = enemyHP1 - damagetail;
  //                                              enemyHP2 = enemyHP2 - damagetail;
  //                                              System.Console.WriteLine("William Worm rushes over and attacks both target with his tail");
  //                                              System.Console.WriteLine("");
  //                                              System.Console.WriteLine("You have done " + damagetail + " points of damage to both bugs!");
  //                                              System.Console.ReadKey();
  //                                              break;
  //                                          case "B":

  //                                              System.Console.Clear();
  //                                              System.Console.WriteLine("What Bug do you attack ");
  //                                              System.Console.WriteLine("");
  //                                              System.Console.WriteLine("A.Bug Two   B.Bug One");
  //                                              input = System.Console.ReadLine();
  //                                              switch (input.ToUpper())
  //                                              {
  //                                                  case "A":

  //                                                      int damagecrit = rand.Next(6, 14);
  //                                                      enemyHP2 = enemyHP2 - damagecrit;
  //                                                      System.Console.WriteLine("William Worm pulls out his glock and shoots Bug Two in the face");
  //                                                      System.Console.ReadKey();
  //                                                      System.Console.WriteLine("You Have done " + damagecrit + " points of damage to Bug Two");
  //                                                      System.Console.ReadKey();
  //                                                      if (enemyHP2 <= 0 && hasDiedYet == true)
  //                                                      {
  //                                                          System.Console.WriteLine("You have killed Bug Two!");
  //                                                          System.Console.ReadKey();
  //                                                          hasDiedYet = false;
  //                                                      }
  //                                                      else
  //                                                      {
  //                                                          System.Console.Clear();
  //                                                      }
  //                                                      break;
  //                                                  case "B":
  //                                                      int damage1crit = rand.Next(6, 14);
  //                                                      enemyHP1 = enemyHP1 - damage1crit;
  //                                                      System.Console.WriteLine("William Worm pulls out his glock and shoots Bug One in the face");
  //                                                      System.Console.ReadKey();
  //                                                      System.Console.WriteLine("You Have done " + damage1crit + " points of damage to Bug Two");
  //                                                      System.Console.ReadKey();
  //                                                      break;
  //                                                  default:
  //                                                      turnCounter = 0;
  //                                                      System.Console.WriteLine("Not a valid input, you fucking idiot");
  //                                                      System.Console.ReadKey();
  //                                                      break;
  //                                              }
  //                                              break;
  //                                          case "C":

  //                                              if (mailBombPlanted == false)
  //                                              {
  //                                                  mailBombPlanted = true;
  //                                                  turnsMailBombPlanted++;
  //                                                  System.Console.Clear();
  //                                                  System.Console.WriteLine("William Worm sends a mail bomb to the bugs");
  //                                                  System.Console.ReadKey();




  //                                              }
  //                                              else
  //                                              {
  //                                                  turnCounter = 0;
  //                                                  System.Console.WriteLine("Nice try bitch, theres already one in the mail");
  //                                                  System.Console.ReadKey();

  //                                              }
  //                                              break;
  //                                          case "D":
  //                                              System.Console.WriteLine("Honestly idk what to put here");
  //                                              break;
  //                                          case "E":
  //                                              turnCounter = 0;
  //                                              break;
  //                                          default:
  //                                              turnCounter = 0;
  //                                              System.Console.WriteLine("Not a valid input");
  //                                              System.Console.ReadKey();
  //                                              break;




  //                                      }
  //                                      break;
  //                                  case "C":
  //                                      System.Console.WriteLine("Ill figure this part out later");
  //                                      System.Console.ReadKey();
  //                                      break;
  //                                  default:
  //                                      turnCounter = 0;
  //                                      System.Console.WriteLine("Not a valid input");
  //                                      System.Console.ReadKey();
  //                                      break;





  //                              }
  //                          }
  //                          else if (enemyHP1 <= 0 && enemyHP2 > 0)
  //                          {
  //                              System.Console.WriteLine("There are One! Bug in front of you. What do you do?");
  //                              System.Console.WriteLine("");
  //                              System.Console.WriteLine("William Worm HP:" + William.health + "/100     Enemy 2 HP:" + enemyHP2 + "/50");
  //                              System.Console.WriteLine("");
  //                              System.Console.WriteLine("A.Attack    B.Ability   C.Items");
  //                              input = System.Console.ReadLine();
  //                              switch (input.ToUpper())
  //                              {
  //                                  case "A":

  //                                      int damage = rand.Next(5, 8);
  //                                      enemyHP2 = enemyHP2 - damage;
  //                                      System.Console.WriteLine("You Have done " + damage + " points of damage");
  //                                      System.Console.ReadKey();
  //                                      if (enemyHP2 <= 0)
  //                                      {
  //                                          System.Console.WriteLine("You have killed Bug Two!");
  //                                          System.Console.ReadKey();

  //                                      }
  //                                      else
  //                                      {
  //                                          System.Console.Clear();
  //                                      }
  //                                      break;

  //                                  case "B":

  //                                      System.Console.Clear();
  //                                      System.Console.WriteLine("Choose an ability");
  //                                      System.Console.WriteLine("");
  //                                      System.Console.WriteLine("A.The Dash   B.Gun   C.Mail Bomb   D.I dont fucking know   E.Go Back");
  //                                      input = System.Console.ReadLine();
  //                                      switch (input.ToUpper())
  //                                      {
  //                                          case "A":
  //                                              int damagetail = rand.Next(3, 10);
  //                                              System.Console.Clear();
  //                                              enemyHP1 = enemyHP1 - damagetail;
  //                                              enemyHP2 = enemyHP2 - damagetail;
  //                                              System.Console.WriteLine("William Worm rushes over and attacks with his tail");
  //                                              System.Console.WriteLine("");
  //                                              System.Console.WriteLine("You have done " + damagetail + " points of damage");
  //                                              System.Console.ReadKey();
  //                                              if (enemyHP2 <= 0)
  //                                              {
  //                                                  System.Console.WriteLine("You have killed Bug Two!");
  //                                                  System.Console.ReadKey();

  //                                              }
  //                                              else
  //                                              {
  //                                                  System.Console.Clear();
  //                                              }
  //                                              break;
  //                                          case "B":
  //                                              int damagecrit = rand.Next(6, 14);
  //                                              enemyHP2 = enemyHP2 - damagecrit;
  //                                              System.Console.WriteLine("William Worm pulls out his glock and shoots Bug Two in the face");
  //                                              System.Console.ReadKey();
  //                                              System.Console.WriteLine("You Have done " + damagecrit + " points of damage to Bug Two");
  //                                              System.Console.ReadKey();
  //                                              if (enemyHP2 <= 0)
  //                                              {
  //                                                  System.Console.WriteLine("You have killed Bug Two!");
  //                                                  System.Console.ReadKey();

  //                                              }
  //                                              else
  //                                              {
  //                                                  System.Console.Clear();
  //                                              }
  //                                              break;



  //                                          case "C":

  //                                              if (mailBombPlanted == false)
  //                                              {
  //                                                  mailBombPlanted = true;
  //                                                  turnsMailBombPlanted++;
  //                                                  System.Console.Clear();
  //                                                  System.Console.WriteLine("William Worm sends a mail bomb to the bugs");
  //                                                  System.Console.ReadKey();




  //                                              }
  //                                              else
  //                                              {
  //                                                  turnCounter = 0;
  //                                                  System.Console.WriteLine("Nice try bitch, theres already one in the mail");
  //                                                  System.Console.ReadKey();

  //                                              }
  //                                              break;
  //                                          case "D":
  //                                              System.Console.WriteLine("Honestly idk what to put here");
  //                                              break;
  //                                          case "E":
  //                                              turnCounter = 0;
  //                                              break;




  //                                      }
  //                                      break;

  //                                  case "C":
  //                                      System.Console.WriteLine("Ill figure this part out later");
  //                                      System.Console.ReadKey();
  //                                      break;



  //                              }
  //                          }
  //                          else if (enemyHP1 > 0 && enemyHP2 <= 0)
  //                          {
  //                              System.Console.WriteLine("There are One! Bug in front of you. What do you do?");
  //                              System.Console.WriteLine("");
  //                              System.Console.WriteLine("William Worm HP:" + William.health + "/100     Enemy 1 HP:" + enemyHP1 + "/50");
  //                              System.Console.WriteLine("");
  //                              System.Console.WriteLine("A.Attack    B.Ability   C.Items");
  //                              input = System.Console.ReadLine();
  //                              switch (input.ToUpper())
  //                              {
  //                                  case "A":

  //                                      int damage = rand.Next(5, 8);
  //                                      enemyHP1 = enemyHP1 - damage;
  //                                      System.Console.WriteLine("You Have done " + damage + " points of damage");
  //                                      System.Console.ReadKey();
  //                                      break;

  //                                  case "B":

  //                                      System.Console.Clear();
  //                                      System.Console.WriteLine("Choose an ability");
  //                                      System.Console.WriteLine("");
  //                                      System.Console.WriteLine("A.The Dash   B.Gun   C.Mail Bomb   D.I dont fucking know   E.Go Back");
  //                                      input = System.Console.ReadLine();
  //                                      switch (input.ToUpper())
  //                                      {
  //                                          case "A":
  //                                              int damagetail = rand.Next(3, 10);
  //                                              System.Console.Clear();
  //                                              enemyHP1 = enemyHP1 - damagetail;
  //                                              System.Console.WriteLine("William Worm rushes over and attacks with his tail");
  //                                              System.Console.WriteLine("");
  //                                              System.Console.WriteLine("You have done " + damagetail + " points of damage");
  //                                              System.Console.ReadKey();
  //                                              break;
  //                                          case "B":
  //                                              int damagecrit = rand.Next(6, 14);
  //                                              enemyHP1 = enemyHP1 - damagecrit;
  //                                              System.Console.WriteLine("William Worm pulls out his glock and shoots Bug One in the face");
  //                                              System.Console.ReadKey();
  //                                              System.Console.WriteLine("You Have done " + damagecrit + " points of damage to Bug One");
  //                                              System.Console.ReadKey();
  //                                              break;



  //                                          case "C":

  //                                              if (mailBombPlanted == false)
  //                                              {
  //                                                  mailBombPlanted = true;
  //                                                  turnsMailBombPlanted++;
  //                                                  System.Console.Clear();
  //                                                  System.Console.WriteLine("William Worm sends a mail bomb to the bugs");
  //                                                  System.Console.ReadKey();




  //                                              }
  //                                              else
  //                                              {
  //                                                  turnCounter = 0;
  //                                                  System.Console.WriteLine("Nice try bitch, theres already one in the mail");
  //                                                  System.Console.ReadKey();

  //                                              }
  //                                              break;
  //                                          case "D":
  //                                              System.Console.WriteLine("Honestly idk what to put here");
  //                                              break;
  //                                          case "E":
  //                                              turnCounter = 0;
  //                                              break;
  //                                          default:
  //                                              System.Console.WriteLine("Not A Valid Fucking INputt");
  //                                              System.Console.ReadKey();
  //                                              turnCounter = 0;
  //                                              break;




  //                                      }
  //                                      break;

  //                                  case "C":
  //                                      System.Console.WriteLine("Ill figure this part out later");
  //                                      System.Console.ReadKey();
  //                                      break;



  //                              }
  //                          }
  //                          else if (enemyHP1 <= 0 && enemyHP2 <= 0)
  //                          {

  //                              System.Console.Clear();
  //                              System.Console.WriteLine("You have Won!");
  //                              System.Console.ReadKey();
  //                              leftDirection1(1);

  //                          }
  //                          else if (William.health <= 0)
  //                          {
  //                              System.Console.WriteLine("You fucking suck game over");
  //                              System.Console.ReadKey();
  //                              break;
                                

  //                          }
  //                      }
  //                      else
  //                      {
  //                          if (mailBombPlanted == true && turnsMailBombPlanted == 2)
  //                          {
                                
  //                              int damagebomb = rand.Next(15, 30);
  //                              enemyHP1 = enemyHP1 - damagebomb;
  //                              enemyHP2 = enemyHP2 - damagebomb;
  //                              System.Console.WriteLine("The bugs recieved a package, I wonder whats inside?");
  //                              System.Console.ReadKey();
  //                              System.Console.Clear();
  //                              System.Console.WriteLine("BOOOOOOOOOOOOOOM! They take " + damagebomb +  "points of damage.");
  //                              System.Console.ReadKey();
  //                              mailBombPlanted = false;
  //                              turnsMailBombPlanted = 0;
                                
                                
  //                          }
  //                          else if (mailBombPlanted == true && turnsMailBombPlanted == 1)
  //                          {
  //                              turnsMailBombPlanted++;
  //                          }

  //                          int damagewilliam = rand.Next(15);
  //                          System.Console.Clear();
  //                          System.Console.WriteLine("The Bugs Attack!");
  //                          System.Console.ReadKey();
  //                          William.health = William.health - damagewilliam;
  //                          System.Console.Clear();
  //                          System.Console.WriteLine("William Worm takes " + damagewilliam + " of damage!");
  //                          System.Console.ReadKey();
  //                      }
  //                  }
  //                  break;

                    


                   
  //          }

		//}


	 //   static void StartGame(string[] args)
		//{
		//	string input;
  //          System.Console.WriteLine("Welcome To William Worm Escape From Bug York! Can you help William Escape?");
		//	input = System.Console.ReadLine();
		//	if (input.ToLower() == "yes")
		//	{
  //              System.Console.WriteLine("Cool");
		//			startGame();
		//	}
		//	else
		//	{
  //              System.Console.WriteLine("Bad");
		//	}

		//}

        static void Main()
        {
            
            //// Setup the engine and create the main window.
            SadConsole.Game.Create(80, 25);

            //// Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;

            //// Start the game.
            SadConsole.Game.Instance.Run();
            SadConsole.Game.Instance.Dispose();
        }


        static void Init()
        {
            //resize window
            Settings.ResizeMode = Settings.WindowResizeOptions.None;
            Settings.ResizeWindow(res.X, res.Y);
            
            // make console
            var console = new Console.Console();
            
            // resize console
            console.Resize(Global.WindowWidth / console.Font.Size.X, Global.WindowWidth / console.Font.Size.Y, false);
            
            // attach console to ink manager and load script
            inkManager = new InkManager(console, "scripts/main.json");

            // attach console to fight manager
            combatManager = new CombatManager(console);

            // enable console
            console.IsVisible = true;
            console.IsFocused = true;
            Global.CurrentScreen = console;
            
        }
    }

}
