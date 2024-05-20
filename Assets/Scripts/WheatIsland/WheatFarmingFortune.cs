using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WheatFarmingFortune : MonoBehaviour
{
    public Clickingmechanic clickingmechanic4;
    public int wheatFarmingFortuneCost;
    public int wheatFarmingFortuneCounter;
    public TMP_Text wheatFarmingFortuneCounterTxt;
    public TMP_Text wheatFarmingFortuneCostTxt;
    // Start is called before the first frame update
    void Start()
    {
        wheatFarmingFortuneCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        WheatFarmingFortuneCostTxT();
        WheatFarmingFortuneCounter();
    }
    public void FarmingFortune()
    {
        if (clickingmechanic4.wheat > wheatFarmingFortuneCost)
        {
            clickingmechanic4.wheat = clickingmechanic4.wheat - wheatFarmingFortuneCost;
            clickingmechanic4.passiveclickercounter = clickingmechanic4.passiveclickercounter * 2;
            clickingmechanic4.amountofclicks = clickingmechanic4.amountofclicks * 2;
            wheatFarmingFortuneCost = wheatFarmingFortuneCost + wheatFarmingFortuneCost / 4 * 3;
            wheatFarmingFortuneCounter += 1;

        }
    }
        public void WheatFarmingFortuneCostTxT()
        {
            wheatFarmingFortuneCostTxt.text =  "" + wheatFarmingFortuneCost;
        }

        public void WheatFarmingFortuneCounter()
        {
            wheatFarmingFortuneCounterTxt.text = "" + wheatFarmingFortuneCounter;
        }
    }


