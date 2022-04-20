using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{

    public Image healthBar1;
    public Image healthBar2;
    public float health;
    public float startHealth;

    public GameObject player1;
    public GameObject player2;

    public int P1Life;
    public int P2Life;

    void Update()
    {

        if (healthBar1 == null)
            healthBar1 = GameObject.Find("Healthbar_bg1").transform.GetChild(0).GetComponent<Image>();



       if(P1Life <= 0)
        {
            player1.SetActive(false);
            Time.timeScale = 0f;
        }

        if (P1Life <= 0)
        {
            player1.SetActive(false);
            Time.timeScale = 0f;
        }
    }

    public void HurtP1()
    {
       
    }

    public void HurtP2()
    {

    }
    public void onDamage2(int damage)
    {
        health = health - damage;
        healthBar2.fillAmount = health / startHealth;
    }
    
    public void onDamage1(int damage)
    {
        health = health - damage;
        healthBar1.fillAmount = health / startHealth;
    }
}
