using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    
    public GameObject notEnoughMoney;
    public TextMeshProUGUI coins;

    private void Start()
    {
        notEnoughMoney.SetActive(false);
    
     
    }

    private IEnumerator NotEnoughMoney()
    {
        notEnoughMoney.SetActive(true);
        yield return new WaitForSeconds(1f);
        notEnoughMoney.SetActive(false);
    }
    public void Update()
    {
        if (collectible.coinsNr < 0)
        {
            collectible.coinsNr = 0;
        }
        coins.text = collectible.coinsNr.ToString();
    }

    public void Hamburger()
    {
        if (collectible.coinsNr >= 3)
        {
            collectible.coinsNr -= 3;
        }
        else
        {
            StartCoroutine(NotEnoughMoney());
        }
    }

    public void Pizza()
    {
        if (collectible.coinsNr >= 5)
        {
            collectible.coinsNr -= 5;
        }
        else
        {
            StartCoroutine(NotEnoughMoney());
        }
    }

    public void Pancakes()
    {
        if (collectible.coinsNr >= 2)
        {
            collectible.coinsNr -= 2;
        }
        else
        {
            StartCoroutine(NotEnoughMoney());
        }
    }
    public void Hotdog()
    {
        if (collectible.coinsNr >= 2)
        {
            collectible.coinsNr -= 2;
        }
        else
        {
            StartCoroutine(NotEnoughMoney());
        }
    }
}
