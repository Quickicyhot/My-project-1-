using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WheatFarmingFortune : MonoBehaviour
{
    public Clickingmechanic clickingmechanic4;
    public int wheatFarmingFortuneCost;
    public int wheatFarmingFortuneLevel;
    public TMP_Text wheatFarmingFortuneCostTxT;
    public TMP_Text wheatFarmingFortuneLevelTxT;
    public WheatRng wheatRng;
    public GameObject wheatFarmingFortuneBuyButton;
    public GameObject wheatFarmingFortuneImage;

    // Start is called before the first frame update
    void Start()
    {
        wheatFarmingFortuneLevel = 0;
        wheatFarmingFortuneCost = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
        WheatFarmingFortuneCostTxT();
        WheatFarmingFortuneLevelTxT();

    }
    public void FarmingFortune()
    {
        if(wheatRng.amountOfEnchantedWheat > wheatFarmingFortuneCost)
        {
            wheatRng.amountOfEnchantedWheat = wheatRng.amountOfEnchantedWheat - wheatFarmingFortuneCost;
            clickingmechanic4.passiveclickercounter = clickingmechanic4.passiveclickercounter * 2;
            clickingmechanic4.amountofclicks = clickingmechanic4.amountofclicks * 2;
            wheatFarmingFortuneLevel += 1;
            wheatFarmingFortuneCost = wheatFarmingFortuneCost + wheatFarmingFortuneCost / 4 * 3;
        }
    }

    public void WheatFarmingFortuneCostTxT()
    {
        wheatFarmingFortuneCostTxT.text = "EWheat" + wheatFarmingFortuneCost;
        
    }
    public void WheatFarmingFortuneLevelTxT()
    {
        wheatFarmingFortuneLevelTxT.text =""+ wheatFarmingFortuneLevel;
    }
}
