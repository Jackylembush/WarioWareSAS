using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testing;

namespace TrioSAS
{
    namespace Footboom
    {
        /// <summary>
        /// Steve Guitton
        /// </summary>
        
        public class PlayerControllerResult : TimedBehaviour
        {
            public bool winningCondition;

            public override void Start()
            {
                base.Start(); //Do not erase this line!

            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!

                if (Input.GetButtonDown("A_Button"))
                {
                    gameObject.GetComponent<BarMovement>().barSpeed = 0;
                    if (winningCondition == true)
                    {
                        Debug.Log("You Win");
                        Manager.Instance.Result(true);
                    }
                    else
                    {
                        Debug.Log("You lose");
                        Manager.Instance.Result(false);
                    }
                }

                if (Input.GetKeyDown("space"))
                {
                    gameObject.GetComponent<BarMovement>().barSpeed = 0;
                    if (winningCondition == true)
                    {
                        Debug.Log("You Win");
                        Manager.Instance.Result(true);
                    }
                    else
                    {
                        Debug.Log("You lose");
                        Manager.Instance.Result(false);
                    }
                }

                if (Tick == 8)
                {
                    Manager.Instance.Result(false);
                }

            }

            void OnTriggerEnter2D(Collider2D col)
            {
                winningCondition = true;
            }

            void OnTriggerExit2D(Collider2D col)
            {
                winningCondition = false;
            }

        }
    }
}