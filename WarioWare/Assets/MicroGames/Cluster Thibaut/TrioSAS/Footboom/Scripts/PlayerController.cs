using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TrioSAS
{
    namespace Footboom
    {
        /// <summary>
        /// Steve Guitton
        /// </summary>
        
        public class PlayerController : MonoBehaviour
        {
            public bool winningCondition;

            // Update is called once per frame
            void Update()
            {
                if (Input.GetButtonDown("A_Button"))
                {
                    gameObject.GetComponent<BarMovement>().barSpeed = 0;
                    if (winningCondition == true)
                    {
                        Debug.Log("You Win");
                    }
                    else
                    {
                        Debug.Log("You lose");
                    }
                }

                if (Input.GetKeyDown("space"))
                {
                    gameObject.GetComponent<BarMovement>().barSpeed = 0;
                    if (winningCondition == true)
                    {
                        Debug.Log("You Win");
                    }
                    else
                    {
                        Debug.Log("You lose");
                    }
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
