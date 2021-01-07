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
            public AnimateCannonBall anim;
            public bool winningCondition;
            public SuccessZoneSize difficulty;
            public BarMovement speedBpm;
            private bool endGame;
            public FailAnimate failure;

            public override void Start()
            {
                base.Start(); //Do not erase this line!

                switch(currentDifficulty)
                {
                    case Manager.Difficulty.EASY:
                        difficulty.SizeEasy();
                        break;
                    case Manager.Difficulty.MEDIUM:
                        difficulty.SizeMedium();
                        break;
                    case Manager.Difficulty.HARD:
                        difficulty.SizeHard();
                        break;
                }

                switch(bpm)
                {
                    case (float)Manager.BPM.Slow:
                        speedBpm.speedSlow();
                        break;
                    case (float)Manager.BPM.Medium:
                        speedBpm.speedMedium();
                        break;
                    case (float)Manager.BPM.Fast:
                        speedBpm.speedFast();
                        break;
                    case (float)Manager.BPM.SuperFast:
                        speedBpm.speedVeryFast();
                        break;
                }
            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!

                if (Input.GetButton("A_Button") && endGame == false)
                {
                    gameObject.GetComponent<BarMovement>().barSpeed = 0;
                    if (winningCondition == true)
                    {
                        Manager.Instance.Result(true);
                        anim.ActivateAnimation();
                        
                        
                    }
                    else
                    {
                        Manager.Instance.Result(false);
                        failure.ActivateFail();
                    }
                    endGame = true;
                }
                if (Input.GetKey("space") && endGame == false)
                {
                    gameObject.GetComponent<BarMovement>().barSpeed = 0;
                    if (winningCondition == true)
                    {
                        Manager.Instance.Result(true);
                        anim.ActivateAnimation();
                       
                    }
                    else
                    {
                        
                        Manager.Instance.Result(false);
                        failure.ActivateFail();
                    }
                    endGame = true;
                }
                if (Tick == 8 && endGame == false)
                {
                    gameObject.GetComponent<BarMovement>().barSpeed = 0;
                    Manager.Instance.Result(false);
                    failure.ActivateFail();
                    endGame = true;
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