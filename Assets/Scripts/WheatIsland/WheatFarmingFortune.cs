using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WheatFarmingFortune : MonoBehaviour
{
    public Clickingmechanic clickingmechanic4;
    public int wheatFarmingFortuneCost;
<<<<<<< HEAD
    public int wheatFarmingFortuneCounter;
    public TMP_Text wheatFarmingFortuneCounterTxt;
    public TMP_Text wheatFarmingFortuneCostTxt;
    // Start is called before the first frame update
    void Start()
    {
        wheatFarmingFortuneCounter = 0;
=======
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
>>>>>>> 6627f48daba3cf67ee843f6548201aea4364b637
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        WheatFarmingFortuneCostTxT();
        WheatFarmingFortuneCounter();
=======
        
        WheatFarmingFortuneCostTxT();
        WheatFarmingFortuneLevelTxT();

>>>>>>> 6627f48daba3cf67ee843f6548201aea4364b637
    }
    public void FarmingFortune()
    {
        if(wheatRng.amountOfEnchantedWheat > wheatFarmingFortuneCost)
        {
<<<<<<< HEAD
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


=======
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
>>>>>>> 6627f48daba3cf67ee843f6548201aea4364b637
