using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheatDataManager : MonoBehaviour

    
{
    private static WheatDataManager instance;
    //Clicking mechanics
    public int wheat;
    public int amountofclicks;
    public int passiveclicks;
    public int passiveclickercounter;
    //enchanted Wheat
    //Stone hoe manager
    public int stoneHoeCost;
    public int stonehoeamountofclicks;
    public double stonehoemoney;
    public int stonehoecounter;
    public int stonehoemoney2;
    //wheat rng
    public int amountOfEnchantedWheat;
    public int wheatRngNum;
    //wheat farming fortune
    public int wheatFarmingFortuneCost;
    public int wheatFarmingFortuneCounter;
    //wheat minion manager
    public int wheatMinionClicks;
    public int wheatMinionMoney;
    public int wheatMinionLevel;
    public int wheatminioncost2;
    // stone wooden manager (done)
    public int woodenHoeCost;
    public int woodenhoeamountofclicks;
    public int woodenHoeCounter;


    void Awake()
    {
        if (instance == null)
        {
            // If no GameManager instance exists, set this as the instance and don't destroy it on load
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If an instance already exists, destroy this duplicate instance
            Destroy(gameObject);
        }
    }

    // Other GameManager methods and properties...
}
