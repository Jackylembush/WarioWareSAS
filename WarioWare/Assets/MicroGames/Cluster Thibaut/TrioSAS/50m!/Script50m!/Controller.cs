using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : TimedBehaviour
{
    private float speed;
    private float speedIncrementation;

    public override void Start()
    {
        base.Start(); //Do not erase this line!

        speed = 0f; 

        switch (currentDifficulty)
        {
            case Difficulty.EASY:
                speedIncrementation = 0.75f;
                break;

            case Difficulty.MEDIUM:
                speedIncrementation = 0.5f;
                break;

            case Difficulty.HARD:
                speedIncrementation = 0.4f;
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        speed -= (speed/2) * Time.deltaTime;
        speed = Mathf.Max(0f, speed);
        PlayerMovement();
        //Debug.Log(speed);
    }

    private void PlayerMovement()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
    }

    public void PlayerInput()
    {
        speed += speedIncrementation;
    }

    public void PlayerStop()
    {
        speed = 0;
        speedIncrementation = 0;
    }
}
