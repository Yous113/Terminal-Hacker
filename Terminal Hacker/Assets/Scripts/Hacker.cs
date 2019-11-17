using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Terminal.WriteLine("Hello Commander");
        Terminal.WriteLine("What would yoou like to hack into?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for the local libarary");
        Terminal.WriteLine("Press 2 for NASA");
        Terminal.WriteLine("Press 3 for the FBI");
        Terminal.WriteLine("Enter your selection: ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
