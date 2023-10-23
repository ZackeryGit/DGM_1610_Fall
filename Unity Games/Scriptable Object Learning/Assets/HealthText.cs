using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using System.Globalization;
using TMPro;



public class TextLabelBehavior : MonoBehaviour
{
    public TextMeshProUGUI label;
    public PlayerData playerData;

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        label.text = playerData.health.ToString(CultureInfo.InvariantCulture);
    }
}
