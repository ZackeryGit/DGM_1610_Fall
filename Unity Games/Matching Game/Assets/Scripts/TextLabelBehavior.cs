using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using System.Globalization;
using TMPro;
using UnityEngine.Events;

public class TextLabelBehavior : MonoBehaviour
{
    private TextMeshProUGUI label;
    public UnityEvent startEvent;
    

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
    }

    public void UpdateLabel(FloatData score)
    {
        label.text = score.value.ToString(CultureInfo.InvariantCulture);
    }
    public void UpdateLabel(IntData score)
    {
        label.text = score.value.ToString(CultureInfo.InvariantCulture);

    }
    public void UpdateLabel(string score)
    {
        label.text = score.ToString(CultureInfo.InvariantCulture);

    }
}