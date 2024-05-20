using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WoodenHoeManager : MonoBehaviour
{
    public Clickingmechanic clickingmechanic1;
    public GameObject WoodenHoe1;
    public GameObject StonehoeImage;

    public TMP_Text woodenHoeText;
    public TMP_Text woodenHoeCounter1;
    public int woodenHoeCost;
    public int woodenhoeamountofclicks;
    public double woodenhoemoney;
    public string woodenHoeCost1;
    public int woodenHoeCounter;
    void Start()
    {
        woodenhoeamountofclicks = 0;
        woodenHoeCost = 50;
        woodenHoeCost1 = "Cost; ";
        
    }

    // Update is called once per frame
    void Update()
    {
       
        woodenhoemoney = clickingmechanic1.wheat;
        woodenHoeText.text = woodenHoeCost1 + woodenHoeCost;
        woodenHoeCounter1.text = "" + woodenHoeCounter;
        WheatDataSaver.woodenHoeCost = woodenHoeCost1;
        WheatDataSaver.woodenhoeamountofclicks = woodenhoeamountofclicks;
        WheatDataSaver.woodenHoeCounter = woodenHoeCounter;
    }

    public void woodenHoe()
    {
        if (woodenhoemoney > woodenHoeCost)
        {
            
            woodenhoeamountofclicks = woodenhoeamountofclicks + 1;
            clickingmechanic1.wheat = clickingmechanic1.wheat - woodenHoeCost;
            woodenHoeCost = woodenHoeCost + woodenHoeCost/8;
            clickingmechanic1.amountofclicks = clickingmechanic1.amountofclicks + 1;
            woodenHoeCounter += 1;
            StonehoeImage.SetActive(true);
        }


    }


}
