using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public UnityEvent triggerExitEvent;

    public void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
    public void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}
