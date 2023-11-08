using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    
    public int value;

    public void UpdateValue(int num)
    {
        value += num;
    }

    public void CompareValue(IntData num)
    {
        if (value >= num.value)
        {

        } else
        {
            value = num.value;
        }
    } 

    public void SetValue(int num)
    {
        value = num;
    }
    public void SetValue(IntData num)
    {
        value = num.value;
    }
}
