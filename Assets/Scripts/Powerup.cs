using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : ScriptableObject
{

    public bool isActive;

    [SerializeField]
    protected PowerupStats time;

    [SerializeField] 
    protected int currentLevel = 1;

    [SerializeField]
    protected int maxLevel = 3;

    [SerializeField]
    protected int[] UpgradeCosts;

    public bool IsMaxedOut()
    {
        return currentLevel == maxLevel;
    }

    public int GetNextUpgradeCost()
    {
        if(IsMaxedOut() == false)
        {
            return UpgradeCosts[currentLevel-1];
        }
        else
        {
            return 0;
        }
    }
    public void Upgrade()
    {
        if (IsMaxedOut() == false)
        {
            currentLevel++;
            SavePowerupLevel();
        }
    }

    void Start()
    {
        LoadPowerupLevel();
    }
    private void SavePowerupLevel()
    {
        string key = name + "Level"; 
        PlayerPrefs.SetInt(key, currentLevel);
    }
    private void LoadPowerupLevel()
    {
        string key = name + "Level";
        if (PlayerPrefs.HasKey(key))
        {
            currentLevel = PlayerPrefs.GetInt(key);
        }
    }
    public override string ToString()
    {
        string text = $"{name}\nLVL. {currentLevel}";
        if (IsMaxedOut())

            text += " (MAX)";
        return text;
    }
    public string UpgradeCostString()
    {
        if (!IsMaxedOut())
            return $"UPGRADE\nCOST: {GetNextUpgradeCost()}";
        else
            return "MAXED OUT";
    }

    public float GetTime()
    {
        return time.GetValue();
    }
}
