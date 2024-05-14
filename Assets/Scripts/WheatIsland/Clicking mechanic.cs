using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class Clickingmechanic : MonoBehaviour
{
    public GameObject Counter;
    public TMP_Text CookieCounter;
    public TMP_Text ManualClickingCounter;
    public TMP_Text passiveclicker;

    public int wheat;
    public int amountofclicks;
    public string CookieCounterTextE;
    public string ManualClickingCountertxtE;
    public int passiveclicks;
    public float timer;
    public Boolean timerstart;
    public GameObject exitTutorialButton;


    public int passiveclickercounter;
    public float timePassed;
    void Start()
    {
        wheat = 0;
        amountofclicks = 1;
        CookieCounterTextE = " Wheat";
        ManualClickingCountertxtE = "amount per click ";
        passiveclickercounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        print(wheat);
        cookieCounterText();
        manualClickingCountertxt();
        passiveCookieCounter();
        passiveCookieCounterText();
    }

    public void CounterForCookie()
    {
        wheat = wheat + amountofclicks;


    }

    public void passiveCookieCounter()
    {
        if (timerstart == true)
        {
            timePassed += Time.deltaTime;
            if (timePassed > 1f)
            {
                wheat = wheat + passiveclickercounter;
                timePassed = 0f;

            }

        }
    }

    public void cookieCounterText()
    {

        CookieCounter.text = wheat + CookieCounterTextE;
    }

    public void manualClickingCountertxt()
    {
        ManualClickingCounter.text = ManualClickingCountertxtE + amountofclicks;
    }

   public void passiveCookieCounterText()
    {
        passiveclicker.text =  "passive cookie counter " + passiveclickercounter;
    }
    public void LeaveTutorialButton()
    {
        exitTutorialButton.SetActive(false);
    }
}

    
    
    


