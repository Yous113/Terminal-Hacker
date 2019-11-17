using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    public string greeting = "Hello Commander";
    
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu(greeting);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowMainMenu(string greet)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greet);
        Terminal.WriteLine("What would yoou like to hack into?");
        Terminal.WriteLine("Press 1 for the local libarary");
        Terminal.WriteLine("Enter your selection: ");
    }
}
