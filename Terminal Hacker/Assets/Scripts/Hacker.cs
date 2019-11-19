using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Variables
    public string greeting = "Hello";
    public int level;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("What would yoou like to hack into?");
        Terminal.WriteLine("Press 1 for the local libarary");
        Terminal.WriteLine("Press 2 for NASA");
        Terminal.WriteLine("Enter your selection: ");
    }

    

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        } 
        else if(input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Plese choose a valid level");
        }
    }

    void StartGame()
    {
        Terminal.WriteLine("You have chosen level " + level);
    }
}
