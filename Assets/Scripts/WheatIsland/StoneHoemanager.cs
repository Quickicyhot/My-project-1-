using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class StoneHoeManagerr : MonoBehaviour
{
    public Clickingmechanic clickingmechanic2;
    public GameObject stoneHoe1;
    public GameObject WheatminionImage;
    

    public TMP_Text stoneHoetext;
    public TMP_Text stonehoecountertext;
    public int stoneHoeCost;
    public int stonehoeamountofclicks;
    public double stonehoemoney;
    public string stoneHoeCost1;
    public int stonehoecounter;
    public int stonehoemoney2;
    
    void Start()
    {
        stoneHoeCost = 500;
        stoneHoeCost1 = "Cost: ";
        stonehoeamountofclicks = 1;
        stonehoecounter = 1;

    }

    // Update is called once per frame
    void Update()
    {

        stonehoemoney = clickingmechanic2.wheat;
        stoneHoetext.text = stoneHoeCost1 + stoneHoeCost;
        stonehoecountertext.text = "" + stonehoecounter;
        
    }

    public void stoneHoe()
    {
        if (stonehoemoney > stoneHoeCost)
        {

            stonehoeamountofclicks = stonehoeamountofclicks + 5;
            clickingmechanic2.wheat = clickingmechanic2.wheat - stoneHoeCost;
            stoneHoeCost = stoneHoeCost + stoneHoeCost/8;
            clickingmechanic2.amountofclicks = clickingmechanic2.amountofclicks + 5;
            stonehoecounter += 1;
            stonehoemoney2 = (int)stonehoemoney;
            WheatminionImage.SetActive(true);
        }


    }


}
