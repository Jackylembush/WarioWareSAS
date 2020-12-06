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
        
        public class BarMovement : MonoBehaviour
        {
            public float barSpeed;
            public int modifier;
            // Update is called once per frame
            void Update()
            {
                transform.Translate(Vector3.up * barSpeed * Time.deltaTime);


            }

            void OnCollisionEnter2D(Collision2D col)
            {
                barSpeed = -barSpeed;
            }
        }
    }
}
