using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GoBehavior : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;

    private bool canRun;
    public IntData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    public bool CanRun { get => canRun; set => canRun = value; }

    private void Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startEvent.Invoke();
    }

    public void StartCounting ()
    {
        
        StartCoroutine(Counting());
    }

    private IEnumerator Counting()
    {

        startCountEvent.Invoke();
        yield return wfsObj;
        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }
        endCountEvent.Invoke();
    }
    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }
    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            repeatUntilFalseEvent.Invoke();
            yield return wfsObj;
        }
    }
    
}
