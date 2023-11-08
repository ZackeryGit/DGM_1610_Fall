using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DraggableBehavior : MonoBehaviour
{
    private Camera cameraObj;
    public bool dragable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;
    // Start is called before the first frame update
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position -cameraObj.ScreenToWorldPoint(Input.mousePosition);

        dragable = true;
        startDragEvent.Invoke();
        yield return new WaitForFixedUpdate();
        while (dragable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }
    private void OnMouseUp()
    {
        dragable = false;
        endDragEvent.Invoke();
    }
}
