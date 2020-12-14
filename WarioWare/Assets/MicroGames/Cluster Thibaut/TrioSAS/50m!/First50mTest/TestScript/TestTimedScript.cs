using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testing;

namespace SAS
{
    namespace Cinquante
    {
        public class TestTimedScript : TimedBehaviour
        {
            private bool p1;
            private bool p2;
            private int playerCount;
            public GameObject YouLose;
            public GameObject YouWin;

            public override void Start()
            {
                base.Start(); //Do not erase this line!

                p1 = false;
                p2 = false;
                playerCount = 0;
            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!

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
            }

            //Win Condition
            private void OnTriggerEnter(Collider col)
            {
                if (col.gameObject.name == "Tower")
                {

                    Debug.Log("You won");
                    YouWin.SetActive(true);
                    Manager.Instance.Result(true);
                }
            }

            //TimedUpdate is called once every tick.

            //Lose Condition
            public override void TimedUpdate()
            {
                base.TimedUpdate();

                if (Tick == 8)
                {
                    Debug.Log("You lose");
                    YouLose.SetActive(true);
                    Manager.Instance.Result(false);
                }
            }
        }
    }
}