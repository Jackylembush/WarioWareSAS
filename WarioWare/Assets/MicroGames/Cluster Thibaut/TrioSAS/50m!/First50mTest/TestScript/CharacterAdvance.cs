using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAdvance : MonoBehaviour
{
    private bool p1;
    private bool p2;
    private int playerCount;
   // private bool playerEnd; 

    void Start()
    {
        p1 = false;
        p2 = false;
       // playerEnd = false;
        playerCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //A = Gachette gauche
        if (Input.GetKeyDown(KeyCode.A) && p1 == false)
            {
            Debug.Log("Pas gauche");
            p1 = true;
            p2 = false;
        }

        //Z = Gachette droite
        if (Input.GetKeyDown(KeyCode.Z) && p2 == false)
        {
            Debug.Log("Pas droit");
            p2 = true;
            p1 = false;
            playerCount += 1;
        }

        if (playerCount == 10)
        {
            //playerEnd = true;
                Debug.Log("You won");
        }
    }
}
