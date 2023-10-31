using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;


[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public float health;
    public float speed;
    public float ammo;

    public void SetHealth (float num)
    {
        health = num;
    }
    public void SetSpeed(float num)
    {
        speed = num;
    }
    public void SetAmmo(float num)
    {
        ammo = num;
    }
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
    public void UpdateAmmo(float num)
    {
        ammo += num;
        if (ammo < 0)
        {
            ammo = 0;
        }
    }
}