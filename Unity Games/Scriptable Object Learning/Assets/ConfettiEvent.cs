using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ConfettiEvent : MonoBehaviour
{
    public UnityEvent conffeti;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && conffeti != null)
        {
            conffeti.Invoke();
        }
    }
}
