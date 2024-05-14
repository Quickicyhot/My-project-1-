using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wheatminionmanager : MonoBehaviour
{
    public Clickingmechanic clickingmechanic3;

    public GameObject wheatMinion1;
    public TMP_Text wheatMinionText;
    public TMP_Text wheatMinionLevelCounter;
    public int wheatMinionClicks;
    public int wheatMinionMoney;
    
    public int wheatMinionLevel;
    public string wheatMinionCost1;
    public int wheatminioncost2;

    // Start is called before the first frame update
    void Start()
    {
        wheatMinionLevel = 0;
        wheatminioncost2 = 750;
        wheatMinionCost1 = "Cost: ";
    }

    // Update is called once per frame
    void Update()
    {
        wheatMinionMoney = clickingmechanic3.wheat;
        wheatMinionText.text = wheatMinionCost1 + wheatminioncost2;
        wheatMinionLevelCounter.text = "" + wheatMinionLevel;
    }

    public void WheatMinion()
    {
       if( clickingmechanic3.wheat > wheatminioncost2)
        {
            wheatMinionClicks = wheatMinionClicks + 1;
            clickingmechanic3.wheat = clickingmechanic3.wheat - wheatminioncost2;
            wheatminioncost2 = wheatminioncost2 + wheatminioncost2 / 8;
            clickingmechanic3.passiveclicks = clickingmechanic3.passiveclicks + 1;
            wheatMinionLevel += 1;
            clickingmechanic3.timerstart = true;
            clickingmechanic3.passiveclickercounter = clickingmechanic3.passiveclickercounter + 1;
        }
    }

}
