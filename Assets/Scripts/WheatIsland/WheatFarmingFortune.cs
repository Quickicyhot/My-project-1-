using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WheatFarmingFortune : MonoBehaviour
{
    public Clickingmechanic clickingmechanic4;
    public int wheatFarmingFortuneCost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FarmingFortune()
    {
        if (clickingmechanic4.wheat > wheatFarmingFortuneCost)
        {
            clickingmechanic4.wheat = clickingmechanic4.wheat - wheatFarmingFortuneCost;
            clickingmechanic4.passiveclickercounter = clickingmechanic4.passiveclickercounter + 2;

        }
    }
}
