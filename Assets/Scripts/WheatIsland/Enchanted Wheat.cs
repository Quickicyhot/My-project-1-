using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnchantedWheatManager : MonoBehaviour
{
    public GameObject enchantedWheat;
    public Clickingmechanic Clickingmechanic4;
    public int enchantedWheatPrice;
    public WheatRng wheatRNG;
    // Start is called before the first frame update
    void Start()
    {
        enchantedWheatPrice = 5000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnchantedWheat()
    {
        if (Clickingmechanic4.wheat > enchantedWheatPrice)
        {
            Clickingmechanic4.wheat = Clickingmechanic4.wheat - enchantedWheatPrice;
            wheatRNG.amountOfEnchantedWheat += 1;

        }
    }
}
