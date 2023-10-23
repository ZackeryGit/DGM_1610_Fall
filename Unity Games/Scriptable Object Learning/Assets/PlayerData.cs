using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;


[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public float health;
    public float speed;

    public void UpdateHealth(float num)
    {
        health += num;
    }
    public void UpdateSpeed(float num)
    {
        speed += num;
        if (speed < 1)
        {
            speed = 1;
        }
    }
}