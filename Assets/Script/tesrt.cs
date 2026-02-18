using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tesrt : MonoBehaviour
{
    public int mxHP = 100;
    public int myHP;
    public HealthBar healthBar;
    public int i = 10;
    // Start is called before the first frame update
    void Start()
    {
        myHP = mxHP;
        healthBar.SetMaxHealth(mxHP);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            TakeDamage(10);
           

        }
        
    }
    void TakeDamage(int damage)
    {

        myHP -= damage;
        healthBar.SetHealth(myHP);
    }
}
