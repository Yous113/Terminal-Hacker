﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game confirguration data
    // Arrays
    string[] level1Passwords = {"books", "aisle", "shelf", "password", "font", "borrow" };
    string[] level2Passwords = {"starfields", "telescope","environment" , "exploration", "astronauts"};

    // Game state
    // Variables
    int level;
    string password;
    enum Screen { MainMenu, Password, Win}
    Screen currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }
    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would yoou like to hack into?");
        Terminal.WriteLine("Press 1 for the local libarary");
        Terminal.WriteLine("Press 2 for NASA");
        Terminal.WriteLine("Enter your selection: ");
    }

    

    void OnUserInput(string input)
    {
        if (input == "menu")// we can always direct to main menu
        {
            ShowMainMenu();
        }
        else if(currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2");
        if(isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Plese choose a valid level");
        }
    }


    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        switch(level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            default:
                Debug.LogError("invalid level number");
                break;
        }
        Terminal.WriteLine("Enter the password: ");
    }

    void CheckPassword(string input)
    {
        if(input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            Terminal.WriteLine("Wrong password!!");
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward()
    {
        switch(level)
        {
            case 1:
                Terminal.WriteLine("Have a book...");
                Terminal.WriteLine(@"

      ______ ______
    _/      Y      \_
   // ~~ ~~ | ~~ ~  \\
  // ~ ~ ~~ | ~~~ ~~ \\  
 //________.|.________\\ 
`----------`-'----------'
"


                );
                break;

            case 2:
                Terminal.WriteLine("Take a look at the sky....");
                Terminal.WriteLine(@"

          == c(___(o(______(_()
                  \=\
                   ) =\
                  //|\\
                  //|| \\
                  // ||  \\
                  //  ||   \\
"
                );
                break;
        }
        
    }
}
