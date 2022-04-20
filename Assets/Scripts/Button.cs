using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public PlayerScript playerScript;
    //public Button button;
    private void Update()
    {
        if (playerScript == null)
        {
            playerScript = GameObject.FindGameObjectWithTag("Player1").GetComponent<PlayerScript>();
        }
    }

    public void snowclick()
    {
        playerScript.snow();
    }
    public void fireclick()
    {
        playerScript.fireB();
    }
    public void stoneclick()
    {
        playerScript.stones();
    }

}// class
