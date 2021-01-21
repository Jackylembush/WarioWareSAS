using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : TimedBehaviour
{
    public float speed;
    private float speedIncrementation;
    private AudioSource Music;

    public AudioSource Run_60Bpm;
    public AudioSource Run_80Bpm;
    public AudioSource Run_100Bpm;

    public override void Start()
    {
        base.Start(); //Do not erase this line!

        speed = 0f;

        Music = Run_80Bpm;

        switch (currentDifficulty)
        {
            case Difficulty.EASY:
                speedIncrementation = 2.8f;
                break;

            case Difficulty.MEDIUM:
                speedIncrementation = 2.6f;
                break;

            case Difficulty.HARD:
                speedIncrementation = 2.4f;
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
    }

    public void MusicScene()
    {
        Music.Play();
    }

    public void PlayerEnd()
    {
        speed = 0;
        speedIncrementation = 0;
            
    }
}
