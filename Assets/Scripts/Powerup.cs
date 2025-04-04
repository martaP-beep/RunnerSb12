using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : ScriptableObject
{

    public bool isActive;

    [SerializeField]
    protected PowerupStats time;

    public float GetTime()
    {
        return time.GetValue();
    }
}
