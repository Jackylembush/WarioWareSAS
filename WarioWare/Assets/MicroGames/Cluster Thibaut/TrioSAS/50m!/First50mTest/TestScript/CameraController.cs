using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Start()
    {
        // GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
        //StartCoroutine(run());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //transform.position = transform.position + new Vector3(0, 0, 3);
            StartCoroutine(run());
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            //transform.position = transform.position + new Vector3(0, 0, 3);
            StartCoroutine(run());
        }
    }

    IEnumerator run()
    {      
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 10);
        yield return new WaitForSeconds(0.1f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }
}
