using System.Collections;
using System.Collections.Generic;
using Testing;
using UnityEngine;

public class Controller : TimedBehaviour
{
    private int speed;
    private Rigidbody rb;

    public override void Start()
    {
        base.Start(); //Do not erase this line!

        rb = GetComponent<Rigidbody>();

        switch(currentDifficulty)
        {
            case Difficulty.EASY:
                speed = 15;
                break;

            case Difficulty.MEDIUM:
                speed = 13;
                break;

            case Difficulty.HARD:
                speed = 11;
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(run());
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            StartCoroutine(run());
        }
    }


    IEnumerator run()
    {      
        rb.velocity = new Vector3(0, 0, speed);
        yield return new WaitForSeconds(0.05f);
        rb.velocity = new Vector3(0, 0, 0);
    }

   
}
