using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int damage;
    public int hp;
    public int healthRegen;
    public int critDamage;
    public int critRate;


    // Start is called before the first frame update
    void Start()
    {
        damage = 1;
        hp = 100;

        healthRegen = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
