using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDList;

    public ColorID currentColor;

    private int num;

    public void SetCurrentColorRandomoly()
    {
        num = Random.Range(0, colorIDList.Count);
        currentColor = colorIDList[num];
        
    }
}