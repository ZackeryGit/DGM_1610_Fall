using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformBehavior : MonoBehaviour
{
    public void ResetToZero ()
    {
        transform.position = Vector3.zero;
        Debug.Log("Please place at: " + Vector3.zero);
    }
}
