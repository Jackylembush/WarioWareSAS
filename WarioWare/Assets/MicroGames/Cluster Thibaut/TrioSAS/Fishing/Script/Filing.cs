using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filing : MonoBehaviour
{
    public void OnValueChanged(float value)
    {
        Debug.Log("New Value" + value);
    }
}
