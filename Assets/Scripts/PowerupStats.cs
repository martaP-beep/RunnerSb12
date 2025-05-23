using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewPowerupStats", menuName ="Powerup/PowerupStats")]
public class PowerupStats : ScriptableObject
{
    [SerializeField]
    private float[] value;

    public float GetValue(int level = 1)
    {
        return value[level-1];
    }
}
