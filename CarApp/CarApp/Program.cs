﻿using CarApp.Controllers;
using System;
using Utilities.Helper;

namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Extention.Print(ConsoleColor.Green, "Welcome");
            BrandController brandController = new BrandController();
            ModelController modelController = new ModelController();
            while (true)
            {

            Menu: Extention.PrintMenu();
                int input = Extention.TryParseMethod();
                if (input >= 0 && input <= 11)
                {
                    switch (input)
                    {
                        case (int)Extention.Menu.Quit:
                            goto Quit;
                        case (int)Extention.Menu.CreateBrand:
                            brandController.CreateBrand();
                            break;
                        case (int)Extention.Menu.UpdateBrand:
                            brandController.UpdateBrand();
                            break;
                        case (int)Extention.Menu.RemoveBrand:
                            brandController.RemoveBrand();
                            break;
                        case (int)Extention.Menu.GetBrand:
                            brandController.GetBrand();
                            break;
                        case (int)Extention.Menu.GetAllBrand:
                            brandController.GetAllBrand();
                            break;
                        case (int)Extention.Menu.AddModelInBrand:
                            brandController.AddModelInBrand();
                            break;
                        case (int)Extention.Menu.UpdateModel:
                            modelController.UpdateModel();
                            break;
                        case (int)Extention.Menu.RemoveModel:
                            modelController.RemoveModel();
                            break;
                        case (int)Extention.Menu.GetAllModel:
                            modelController.GetAllModel();
                            break;
                        case (int)Extention.Menu.CreateModel:
                            modelController.ModelCreat();
                            break;
                        case (int)Extention.Menu.ModelAddBrand:
                            brandController.ModelAddBrand();
                            break;
                        default:
                            goto Menu;
                    }
                }

            }

        Quit: Extention.Print(ConsoleColor.Green, "Thanks");
        }
    }
}
