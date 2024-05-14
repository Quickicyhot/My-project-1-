using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WheatRng : MonoBehaviour
{

    public GameObject wheatButton;
    public int amountOfEnchantedWheat;
    public int wheatRngNum;
    public TMP_Text enchantedWheatRngText;
    public GameObject rngDropText;
    public float rngTimer;
    public GameObject enchantedWheat;
    // Start is called before the first frame update
    void Start()
    {
        wheatRngNum = 10;
        rngDropText.SetActive(false);
        rngTimer = 2.5f;

    }

    // Update is called once per frame
    void Update()
    {
        EnchantedWheatRngText();
    }

    public void WheatRngSystem()
    {
        int min = 0;
        int max = 1000;
        int randomNumber = Random.Range(min, max);
        if (randomNumber <= wheatRngNum)
        {
            amountOfEnchantedWheat = amountOfEnchantedWheat + 1;
            ShowText();
            enchantedWheat.SetActive(true);
        }
    }

    public void EnchantedWheatRngText()
    {
        enchantedWheatRngText.text = "Amount of Enchanted Wheat " + amountOfEnchantedWheat;
    }

    public void ShowText()
    {
        rngDropText.SetActive(true);

        StartCoroutine(HideText());
    }

    IEnumerator HideText()
    {
        yield return new WaitForSeconds(rngTimer);

        rngDropText.SetActive(false);

    }
}