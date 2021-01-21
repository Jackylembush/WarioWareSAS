using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TrioSAS
{
    namespace Cinquante
    {
        public class AudioManagerScript : MonoBehaviour
        {
            public AudioSource StartSound;
            public AudioSource BreathSound;
            public AudioSource StepSound;
            public AudioSource EndSound;

            public AudioClip BreathMoment;
            // Start is called before the first frame update
            public void Start()
            {

            }

            // Update is called once per frame
            public void StartScene()
            {
                StartSound.Play();

            }

            public void Running()
            {
                StepSound.Play();
            }

            public void Breath()
            {
                BreathSound.PlayOneShot(BreathMoment, 0.3f);
               
            }

            public void EndScene()
            {
                EndSound.Play();
            }


        }
    }
}
