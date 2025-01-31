using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    #region Singleton UIController
    public static UIController instance;


    private void Awake()
    {
        instance = this;
    }
    #endregion

    public Image[] heartIcons; 
    public Sprite heartFull, heartEmpty;
    public TMP_Text CollectibleText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealthDisplay(int health, int maxHealth)
    {
        for (int i = 0; i < heartIcons.Length; i++)
        {
            heartIcons[i].enabled = true;

            //if(health <= i)
            //{
            //    heartIcons[i].enabled = false;
            //}
            if(health > i)
            {
                heartIcons[i].sprite = heartFull;
            }
            else
            {
                heartIcons[i].sprite = heartEmpty;
                
                if(maxHealth <= i)
                {
                    heartIcons[i].enabled = false;
                }
            }
        }
    }
    public void UpdateCollectibles(int amount)
    {
        CollectibleText.text = amount.ToString();
    }
}
