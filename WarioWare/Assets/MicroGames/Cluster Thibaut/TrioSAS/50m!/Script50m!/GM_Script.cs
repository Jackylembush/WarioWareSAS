using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testing;

namespace SAS
{
    namespace Cinquante
    {
        public class GM_Script : TimedBehaviour
        {
            private bool p1;
            private bool p2;
            private bool win;
            private bool lose;
            public GameObject YouLose;
            public GameObject YouWin;

            public override void Start()
            {
                base.Start(); //Do not erase this line!

                p1 = false;
                p2 = false;
                win = false;
                lose = false;
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
                }
            }


            #region Winning Condition
            //Win Condition
            private void OnTriggerEnter(Collider col)
            {
                if (col.gameObject.name == "Tower" && lose == false)
                {
                    win = true;
                    Manager.Instance.Result(true);
                    YouWin.SetActive(true);
                }
            }

            //TimedUpdate is called once every tick.

            //Lose Condition
            public override void TimedUpdate()
            {
                base.TimedUpdate();

                if (Tick == 8 && win == false)
                {
                    lose = true;
                    YouLose.SetActive(true);
                    Manager.Instance.Result(false);
                }
            }
            #endregion 

           
        }
    }
}