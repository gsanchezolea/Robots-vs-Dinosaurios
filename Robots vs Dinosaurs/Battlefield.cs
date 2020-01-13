using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{   //variables
    public class Battlefield
    {
        Fleet fleet;
        Herd herd;

        public int roundCounter;

        public int Attacker;
        public int Target;

        //constructor
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();

            Attacker = 3;
            Target = 3;

            roundCounter = 0;
        }


        //Main Menu Method
        public void MainMenu()
        {
            Console.WriteLine("Welcome to Robots vs Dinosaurs \n");
            Console.WriteLine("1) Start Game \n2) Instructions \n3) Exit");
            int menuselection = int.Parse(Console.ReadLine());

            switch (menuselection)
            {
                case 1:
                    StartGame();
                    break;

                case 2:
                    Instructions();
                    MainMenu();
                    break;

                case 3:
                    Console.WriteLine("Bye Bye...press any key to Exit");
                    Console.ReadLine();
                    break;
                                    
                default:
                    Console.WriteLine("Your selection is invalid, please try again..");
                    MainMenu();
                    break;
            }
        }
        
        public void Instructions()
        {
            Console.WriteLine("Welcome to Robots vs Dinosaurs \n");
            Console.WriteLine("Instructions: \n");
            Console.WriteLine("This is a two player turn based game. \nRobots Attack First. \nDinosaurs Attack Second. \nYou select a target and then attack it");
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();            
        }
       

        //Start Game Method
        
        public void StartGame()
        {
           
           
                
                
            while (herd.HerdLifeStatus() && fleet.FleetLifeStatus())
            {


                RoundCounter();
                SelectTargetDinosaur();
                SelectAttackingRobot();
                RobotAtackPhase();
                ResetVariables();
                SelectTargetRobot();
                SelectAttackingDinosaur();
                DinosaurAttackingPhase();
                ResetVariables();
                RoundComplete();
                ShowTotalStats();



            }
            GameOver();
        }

        
        //Robot Attack Round Methods
        public void SelectTargetDinosaur()
        {
            int SelectedDinosaur;
            SelectedDinosaur = 0;

            Console.WriteLine("Robot Turn");
            Console.WriteLine("Please Select Dinosaur to Target");
            Console.WriteLine("1) T-Rex, 2) Spinosaurus, 3) Triceratops");
            int dinosaur = int.Parse(Console.ReadLine());

            switch (dinosaur)
            {
                case 1:
                    if (herd.ListOfDinosaurs[0].dinosaurAlive)
                    {
                        Console.WriteLine("You have targeted " + herd.ListOfDinosaurs[0].dinosaurType);
                        SelectedDinosaur = 0;
                    }
                    else
                    {
                        Console.WriteLine(herd.ListOfDinosaurs[0].dinosaurType + " has been killed, please select another Dinosaur \n");
                        SelectTargetDinosaur();
                        
                    }
                    break;

                case 2:
                    if (herd.ListOfDinosaurs[1].dinosaurAlive)
                    {
                        Console.WriteLine("You have targeted " + herd.ListOfDinosaurs[1].dinosaurType);
                        SelectedDinosaur = 1;
                    }
                    else
                    {
                        Console.WriteLine(herd.ListOfDinosaurs[1].dinosaurType + " has been killed, please select another Dinosaur \n");
                        SelectTargetDinosaur();
                    }
                    break;

                case 3:
                    if (herd.ListOfDinosaurs[2].dinosaurAlive)
                    {
                        Console.WriteLine("You have targeted " + herd.ListOfDinosaurs[2].dinosaurType);
                        SelectedDinosaur = 2;
                    }
                    else
                    {
                        Console.WriteLine(herd.ListOfDinosaurs[2].dinosaurType + " has been killed, please select another Dinosaur \n");
                        SelectTargetDinosaur();
                    }
                    break;

                default:
                    Console.WriteLine("Your selection is invalid, please try again..");
                    SelectTargetDinosaur();
                    break;
            }
            Target = SelectedDinosaur;
            TurnHolder();
        }
        public void SelectAttackingRobot()

        {
            int SelectedRobot;
            SelectedRobot = 0;

            Console.WriteLine("Please Select an Attacking Robot");
            Console.WriteLine("1) C-3PO, 2) R2-D2, 3) T-1000");
            int robot = int.Parse(Console.ReadLine());

            switch (robot)
            {
                case 1:
                    if (fleet.ListOfRobots[0].robotAlive)
                    {
                        Console.WriteLine(fleet.ListOfRobots[0].robotName + " ATTACK!!");
                        SelectedRobot = 0;
                    }
                    else
                    {
                        Console.WriteLine(fleet.ListOfRobots[0].robotName + " has been killed, please select another Robot \n");
                        SelectAttackingRobot();
                    }
                    break;

                case 2:
                    if (fleet.ListOfRobots[1].robotAlive)
                    {
                        Console.WriteLine(fleet.ListOfRobots[1].robotName + " ATTACK!!");
                        SelectedRobot = 1;
                    }
                    else
                    {
                        Console.WriteLine(fleet.ListOfRobots[1].robotName + " has been killed, please select another Robot \n");
                        SelectAttackingRobot();
                    }
                    break;

                case 3:
                    if (fleet.ListOfRobots[2].robotAlive)
                    {
                        Console.WriteLine(fleet.ListOfRobots[2].robotName + " ATTACK!!");
                        SelectedRobot = 2;
                    }
                    else
                    {
                        Console.WriteLine(fleet.ListOfRobots[2].robotName + " has been killed, please select another Robot \n");
                        SelectAttackingRobot();
                    }
                    break;

                default:
                    Console.WriteLine("Your selection is invalid, please try again..");
                    SelectAttackingRobot();
                    break;
            }
            Attacker = SelectedRobot;
            TurnHolder();
        }
        public void RobotAtackPhase()
        {
            int DinosaurSelected = Target;
            int RobotSelected = Attacker;

            herd.ListOfDinosaurs[DinosaurSelected].dinosaurHealth -= fleet.ListOfRobots[RobotSelected].RobotAttack();

            if (herd.ListOfDinosaurs[DinosaurSelected].dinosaurHealth <=0)
            {
                Console.WriteLine(herd.ListOfDinosaurs[DinosaurSelected].dinosaurType + " has become Extinct");
                herd.ListOfDinosaurs[DinosaurSelected].dinosaurAlive = false;
                
            }
            else
            {
                Console.WriteLine(herd.ListOfDinosaurs[DinosaurSelected].dinosaurType + " has " + herd.ListOfDinosaurs[DinosaurSelected].dinosaurHealth + " health left. \n");
                
            }
            TurnHolder();
        }


        //Dinosaur Attack Round Methods
        public void SelectTargetRobot()
        {
            int SelectedRobot;
            SelectedRobot = 0;

            Console.WriteLine("Dinosaur Turn");
            Console.WriteLine("Please Select a Robot to Target");
            Console.WriteLine("1) C-3PO, 2) R2-D2, 3) T-1000");
            int robot = int.Parse(Console.ReadLine());

            switch (robot)
            {
                case 1:
                    if (fleet.ListOfRobots[0].robotAlive)
                    {
                        Console.WriteLine("You have targeted " + fleet.ListOfRobots[0].robotName);
                        SelectedRobot = 0;
                    }
                    else
                    {
                        Console.WriteLine(fleet.ListOfRobots[0].robotName + " has been killed, please select another Robot \n");
                        SelectTargetRobot();
                    }
                    break;

                case 2:
                    if (fleet.ListOfRobots[1].robotAlive)
                    {
                        Console.WriteLine("You have targeted " + fleet.ListOfRobots[1].robotName);
                        SelectedRobot = 1;
                    }
                    else
                    {
                        Console.WriteLine(fleet.ListOfRobots[1].robotName + " has been killed, please select another Robot \n");
                        SelectTargetRobot();
                    }
                    break;

                case 3:
                    if (fleet.ListOfRobots[2].robotAlive)
                    {
                        Console.WriteLine("You have targeted " + fleet.ListOfRobots[2].robotName);
                        SelectedRobot = 2;
                    }
                    else
                    {
                        Console.WriteLine(fleet.ListOfRobots[2].robotName + " has been killed, please select another Robot \n");
                        SelectTargetRobot();
                    }
                    break;

                default:
                    Console.WriteLine("Your selection is invalid, please try again..");
                    SelectTargetRobot();
                    break;
            }
            Target = SelectedRobot;
            TurnHolder();
        }
        public void SelectAttackingDinosaur()

        {
            int SelectedDinosaur;
            SelectedDinosaur = 0;

            Console.WriteLine("Please Select an Attacking Dinosaur");
            Console.WriteLine("1) T-Rex, 2) Spinosaurus, 3) Triceratops");
            int dinosaur = int.Parse(Console.ReadLine());

            switch (dinosaur)
            {
                case 1:
                    if (herd.ListOfDinosaurs[0].dinosaurAlive)
                    {
                        Console.WriteLine(herd.ListOfDinosaurs[0].dinosaurType + " ATTACK!!");
                        SelectedDinosaur = 0;
                    }
                    else
                    {
                        Console.WriteLine(herd.ListOfDinosaurs[0].dinosaurType + " has been killed, please select another Dinosaur \n");
                        SelectAttackingDinosaur();
                    }
                    break;

                case 2:
                    if (herd.ListOfDinosaurs[1].dinosaurAlive)
                    {
                        Console.WriteLine(herd.ListOfDinosaurs[1].dinosaurType + " ATTACK!!");
                        SelectedDinosaur = 1;
                    }
                    else
                    {
                        Console.WriteLine(herd.ListOfDinosaurs[1].dinosaurType + " has been killed, please select another Dinosaur \n");
                        SelectAttackingDinosaur();
                    }
                    break;

                case 3:
                    if (herd.ListOfDinosaurs[2].dinosaurAlive)
                    {
                        Console.WriteLine(herd.ListOfDinosaurs[2].dinosaurType + " ATTACK!!");
                        SelectedDinosaur = 2;
                    }
                    else
                    {
                        Console.WriteLine(herd.ListOfDinosaurs[2].dinosaurType + " has been killed, please select another Dinosaur \n");
                        SelectAttackingDinosaur();
                    }
                    break;

                default:
                    Console.WriteLine("Your selection is invalid, please try again..");
                    SelectAttackingDinosaur();
                    break;
            }
            Attacker = SelectedDinosaur;
            TurnHolder();
        }
        public void DinosaurAttackingPhase()
        {
            int DinosaurSelected = Attacker;
            int RobotSelected = Target;

            fleet.ListOfRobots[RobotSelected].robotHealth -= herd.ListOfDinosaurs[DinosaurSelected].DinosaurAttack();

            if (fleet.ListOfRobots[RobotSelected].robotHealth <= 0)
            {
                Console.WriteLine(fleet.ListOfRobots[RobotSelected].robotName + "'s has been Eliminated");
                fleet.ListOfRobots[RobotSelected].robotAlive = false;                
            }
            else
            {
                Console.WriteLine(fleet.ListOfRobots[RobotSelected].robotName + " has " + fleet.ListOfRobots[RobotSelected].robotHealth + " health left. \n");                
            }
            TurnHolder();
        }


        //Round Count Method
        public void RoundCounter()
        {
            if (roundCounter == 0)
            {
                roundCounter++;
                Console.WriteLine("Round " + roundCounter + "! FIGHT!! \n");
            }
            else if (roundCounter >= 1)
            {
                roundCounter++;
                Console.WriteLine("Round " + roundCounter + "! FIGHT!! \n");
            }
            else
            {
                Console.WriteLine("ERROR 414");
            }
        }
        public void RoundComplete()
        {
            Console.WriteLine("Round " + roundCounter + " Complete!!");
            TurnHolder();
        }


        //Show Statistics Method
        public void ShowTotalStats()
        {         
            for (int i = 0; i < fleet.ListOfRobots.Count; i++)
            {
                if (fleet.ListOfRobots[i].robotAlive)
                {
                    Console.WriteLine(fleet.ListOfRobots[i].robotName + " has " + fleet.ListOfRobots[i].robotHealth + " health remaining.");
                }
                else
                {
                    Console.WriteLine(fleet.ListOfRobots[i].robotName + " has been killed.");
                }
            }
            Console.Write(" \n");
            for (int i = 0; i < herd.ListOfDinosaurs.Count; i++)
            {
                if(herd.ListOfDinosaurs[i].dinosaurAlive)
                {
                    Console.WriteLine(herd.ListOfDinosaurs[i].dinosaurType + " has " + herd.ListOfDinosaurs[i].dinosaurHealth + " health remaining.");
                }
                else
                {
                    Console.WriteLine(herd.ListOfDinosaurs[i].dinosaurType + " has been killed.");
                }
            }
            TurnHolder();
        }

        //Reset Attack and Defend Variables
        public void ResetVariables()
        {
            Attacker = 3;
            Target = 3;
        }

        //GameOver
        public void GameOver()
        {
            Console.WriteLine("GAME OVER \n");
            ShowTotalStats();
            Console.ReadLine();
        }

        //TurnHolder
        public void TurnHolder()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Press Enter to continue.. |");
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }
    }
}






































































            
