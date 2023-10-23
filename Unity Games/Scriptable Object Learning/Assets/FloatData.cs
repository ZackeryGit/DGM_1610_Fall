
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;


[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float num)
    {
        value += num;
    }
}
