using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text coinsText;
    int coins = 0;


    public GameObject menuPanel;
    public GameObject storePanel;


    public Text magnetLevel;
    public Text magnetButton;

    public Text immortalityLevel;
    public Text immortalityButton;

    public Powerup magnet;
    public Powerup immortality;

    public void OpenStore()
    {
        menuPanel.SetActive(false);
        storePanel.SetActive(true);
    }
    public void CloseStore()
    {
        menuPanel.SetActive(true);
        storePanel.SetActive(false);
    }


    void UpdateUI()
    {
       
        if (PlayerPrefs.HasKey("coin"))
        {
            coins = PlayerPrefs.GetInt("coin");
            coinsText.text = "Coins: " + coins;
        }
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
