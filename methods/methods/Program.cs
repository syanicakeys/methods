using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{

            class Program
            {
                private const int Limit = 2;
                private static string[,] informationArray = new string[Limit, 5]; 
                private static int currentIndex = 0;  //track index blabla
                static void Main(string[] args)
                {
                   
                    while (currentIndex < Limit)
                    {
                        Console.Clear();
                        GetUserInformation();
                    }

                
                    PrintData();

         
                    Console.WriteLine("Array is full. Press any key to exit...");
                    Console.ReadKey();
                }

                static void GetUserInformation()
                {
                    Console.Write("Enter Name:");
                    string name = Console.ReadLine();

                    Console.Write("Enter Address:");
                    string address = Console.ReadLine();

                    Console.Write("Enter Phone Number:");
                    string phoneNumber = Console.ReadLine();

                    Console.Write("Enter Email:");
                    string email = Console.ReadLine();

                    Console.Write("Enter Birthday (MM-DD-YYYY):");
                    string birthday = Console.ReadLine();


                    informationArray[currentIndex, 0] = name;
                    informationArray[currentIndex, 1] = address;
                    informationArray[currentIndex, 2] = phoneNumber;
                    informationArray[currentIndex, 3] = email;
                    informationArray[currentIndex, 4] = birthday;

                    currentIndex++;
                    Console.WriteLine("Information added to the array.");
                }

                static void PrintData()
                {
                    Console.WriteLine("Information stored in the array:");
                    for (int i = 0; i < currentIndex; i++)
                    {
                        Console.WriteLine($"Entry {i + 1}:");
                        Console.WriteLine($"Name: {informationArray[i, 0]}");
                        Console.WriteLine($"Address: {informationArray[i, 1]}");
                        Console.WriteLine($"Phone Number: {informationArray[i, 2]}");
                        Console.WriteLine($"Email: {informationArray[i, 3]}");
                        Console.WriteLine($"Birthday: {informationArray[i, 4]}");
                        Console.WriteLine();
                    }
                }
            }
        }



