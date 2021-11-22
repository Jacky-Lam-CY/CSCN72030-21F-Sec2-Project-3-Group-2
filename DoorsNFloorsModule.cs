using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Project3Test
{

    class DoorsNFloors
    {
        //variable declarations
        public bool isOpen = false;
       
        public int humidityVal;

        public double lightWeight = 0.7;
        public double averageWeight = 1.0;
        public double heavyWeight = 1.3;
        public double weightVal;
        public double flagVal;
        public double flagLight = 49.0;
        public double flagAverage = 70.0;
        public double flagHeavy = 91.0;

        //function to toggle door status
        public void toggleStatus()
        {
            if (isOpen == true)
            {
                isOpen = false;
            }
            else if (isOpen == false)
            {
                isOpen = true;
            }
           
        }

        //set humidity
        public void setHumidity(int userInput)
        {
            humidityVal = userInput;
            
        }

        //choose which flag to use based on user input
        public void setFlag(string userInput)
        {
           
            if(userInput == "a")
            {
                flagVal = flagLight;
                weightVal = lightWeight;
            }
            else if (userInput =="b")
            {
                flagVal = flagAverage;
                weightVal = averageWeight;
            }
            else if(userInput == "c")
            {
                flagVal = flagHeavy;
                weightVal = heavyWeight;
            }
           
        }

        public void runFloors()
        {
            

           

            //for every line in the datafile
            foreach (string line in System.IO.File.ReadLines(@"C:\Users\jpden\source\repos\Project3Test\TextFile1.txt"))
            {
                //convert string to double
                double tempVal = Convert.ToDouble(line);

                //determine the multiplier needed and apply
                if (weightVal == lightWeight)
                {
                    tempVal = tempVal * lightWeight;
                }
                else if (weightVal == averageWeight)
                {
                    tempVal = tempVal * averageWeight;
                }
                else if (weightVal == heavyWeight)
                {
                    tempVal = tempVal * heavyWeight;
                }
                //If sensor is not calibrated yet
                else if (weightVal == 0)
                {
                    Console.WriteLine("Sensor not calibrated.");
                    break;
                }

                //round to 2 decimal places
                tempVal = Math.Round(tempVal, 2);
                
                Console.WriteLine(tempVal);
                //pause half a second in between outputting each new line
                Thread.Sleep(500);
            }
            
        }

    }
    class DoorsNFloorsModule 
    {
        static void Main(string[] args)
        {
            //variable declarations
            string userInput;
            string menuSelection;
            string floorMenuSelection;
            string flagSelection;
            string humidSelect;
            int humidInput;
           
            //create new object
            DoorsNFloors myDoorsNFloors = new DoorsNFloors();

            //Menu
            do

            {
                Console.WriteLine("Welcome to the DoorsNFloors Module.\n");
                Console.WriteLine("Please select an option.");
                Console.WriteLine("A) Toggle door Open/Close.");
                if (myDoorsNFloors.isOpen == true)
                {      
                    Console.WriteLine("The door is currently Open");
                }
                else
                {
                    Console.WriteLine("The door is currently Closed");
                }
                Console.WriteLine("B) Set Humidity Value");
                Console.WriteLine("Current Humidity value is: {0}%", myDoorsNFloors.humidityVal);
                Console.WriteLine("C) Open Floors Menu");
                Console.WriteLine("D) Exit DoorsNFloors Module");
                Console.Write("Your Selection: ");

                //Input

                userInput = Console.ReadLine().ToLower();
                menuSelection = userInput.Substring(0, 1);

                //Console.WriteLine("Your selection is {0}\n", menuSelection);
                //Above line used to check input is properly being read

                if(menuSelection == "a")
                {
                    Console.WriteLine("Toggling door status.\n\n");
                    myDoorsNFloors.toggleStatus();
                }
                else if(menuSelection  == "b")
                {
                    Console.WriteLine("Adjusting Humidity Value");
                    Console.WriteLine("Please enter the new integer value you'd like for humidity (0-100):");
                    humidSelect = Console.ReadLine();

                    //convert string value to integer
                    humidInput = Convert.ToInt32(humidSelect);

                    //check if the value for humidity is valid
                    if(humidInput >= 0 && humidInput <=100)
                    {
                        //call function to set humidity
                        Console.WriteLine("New humidity value is: {0}%\n\n", humidInput);
                        myDoorsNFloors.setHumidity(humidInput);
                    }
                    else
                    {
                        //Output for invalid entry
                        Console.WriteLine("Invalid selection for humidity, valid selections are integers between 0 and 100\n\n");
                    }  


                }
                else if(menuSelection == "c")
                {
                    //loop floors menu just like DoorsNFloors menu
                    Console.WriteLine("Navigating to Floors Menu...\n\n");
                    do
                    {
                       
                        Console.WriteLine("Welcome to the floors menu.\n");

                        //If statement depends on current flag value
                        if (myDoorsNFloors.flagVal == myDoorsNFloors.flagAverage)
                        {
                            Console.WriteLine("Current sensor sensitivity set for average weight.");
                        }
                        else if (myDoorsNFloors.flagVal == myDoorsNFloors.flagLight)
                        {
                            Console.WriteLine("Current sensor sensitivity set for light weight.");
                        }
                        else if (myDoorsNFloors.flagVal == myDoorsNFloors.flagHeavy)
                        {
                            Console.WriteLine("Current sensor sensitivity set for heavy weight.");
                        }
                        else
                        {
                            Console.WriteLine("Sensor sensitivity has not yet been calibrated.");
                        }

                        //floors menu
                        Console.WriteLine("Please choose from one of the following options.");
                        Console.WriteLine("a) Change the sensitivity of the sensors.");
                        Console.WriteLine("b) Check the floor sensors.");
                        Console.WriteLine("c) Back to main DoorsNFloors Menu");
                        Console.Write("Your selection:");

                        userInput = Console.ReadLine().ToLower();
                        floorMenuSelection = userInput.Substring(0, 1);

                        if(floorMenuSelection == "a")
                        {
                            Console.WriteLine("a) Set sensitivity for light weight.");
                            Console.WriteLine("b) Set sensitivity for average weight.");
                            Console.WriteLine("c) set sensitivity for heavy weight.");

                            userInput = Console.ReadLine().ToLower();
                            flagSelection = userInput.Substring(0, 1);

                            if(flagSelection == "a" || flagSelection == "b" || flagSelection== "c")
                            {
                               
                                myDoorsNFloors.setFlag(flagSelection);
                                
                                //Used to test that setFlag is working properly.
                                //Console.WriteLine("Current flagVal is: {0}", myDoorsNFloors.flagVal);
                            }
                            
                            else
                            {
                                Console.WriteLine("Invalid Selection.");
                            }
                        }
                        else if(floorMenuSelection =="b")
                        {
                            //Console.WriteLine("Still coding this option");

                            myDoorsNFloors.runFloors();
                        }
                        else if(floorMenuSelection == "c")
                        {
                            Console.WriteLine("Exiting back to DoorsNFLoors Menu...\n\n");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, please select a valid menu option.");
                        }


                    } while (floorMenuSelection != "c");
                }
                else if(menuSelection =="d")
                {
                    Console.WriteLine("Exiting to main module...\n\n");
                }
                else
                {
                    Console.WriteLine("Invalid Input, please select a valid menu option.");
                }

            } while (menuSelection != "d");


        }
    }
}
