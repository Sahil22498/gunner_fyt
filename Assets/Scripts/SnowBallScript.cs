using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallScript : MonoBehaviour
{
    public float SnowballSpeed;
    private Rigidbody2D mybody;

    
    // Start is called before the first frame update
    void Start()
    {
     
        mybody = GetComponent<Rigidbody2D>();

        GetComponent<Effects>();

    }

    // Update is called once per frame
    void Update()
    {
        mybody.velocity = new Vector2(SnowballSpeed, 0);
        
    }

   private void OnTriggerEnter2D(Collider2D collider)
    {
        //print("Attack");

        // Player Fire 
        if (collider.tag == "Player1")
        {
              print("fireee");
            FindObjectOfType<HealthController>().onDamage1(5);

            //collider.GetComponent<HealthController>().onDamage(5);

              Destroy(gameObject);
            // print("Damage player1");
            //  gameObject.SetActive(false);
        }
        if (collider.tag == "Player2")
        {
            print("fireee222");
            FindObjectOfType<HealthController>().onDamage2(5);

           // collider.GetComponent<HealthController>().onDamage(5);

            Destroy(gameObject);
          //  print("Damage player2");
            //  gameObject.SetActive(false);
        }
    }

} //class 





//void OnTriggerEnter2D(Collider2D other)
//{
//    // Player Fire 
//    if (other.tag == "Player1")
//    {
//        FindObjectOfType<Game>().HurtP1();
//        // Debug.Log("Fireeeee");
//    }
//    if (other.tag == "Player2")
//    {
//        FindObjectOfType<Game>().HurtP2();
//        //  Debug.Log("Fireeeeeeeeeeeeeeeeee2");
//    }