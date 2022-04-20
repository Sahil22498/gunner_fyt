using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D mybody;

    public float groundCheckRadius;
    public LayerMask Grounded;

    public bool isGrounded;
    private Animator anim;

    public GameObject snowBall;
    public GameObject fire;
    public GameObject Stone;

    public Transform shootPoint;

    public HealthController healthbar;
  
    void Start()
    {
        shootPoint = GetComponent<Transform>().GetChild(1).transform;
        shootPoint = GetComponent<Transform>().GetChild(3).transform;
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        if (transform.tag == "Player1")
            healthbar = GameObject.Find("Healthbar_bg1").GetComponent<HealthController>();
    }
  
    public void snow()
    {
        GameObject ball = (GameObject)Instantiate(snowBall, shootPoint.position, Quaternion.identity);

        if (transform.position.x < -1f)
            ball.GetComponent<SnowBallScript>().SnowballSpeed *= 1;
        else
        {
            ball.GetComponent<SnowBallScript>().SnowballSpeed *= -1;
            ball.GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    public void fireB()
    {
        GameObject ball = (GameObject)Instantiate(fire, shootPoint.position, transform.rotation);

        if (transform.position.x < -1f)
            ball.GetComponent<SnowBallScript>().SnowballSpeed *= 1;
        else
        {
            ball.GetComponent<SnowBallScript>().SnowballSpeed *= -1;
            ball.GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    public void stones()
    {
        GameObject ball = (GameObject)Instantiate(Stone, shootPoint.position, transform.rotation);

        if (transform.position.x < -1f)
            ball.GetComponent<SnowBallScript>().SnowballSpeed *= 1;
        else
        {
            ball.GetComponent<SnowBallScript>().SnowballSpeed *= -1;
            ball.GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            if (healthbar)
            {
                healthbar.onDamage1(5);
            }
        }

        if (collision.gameObject.tag == "Player2")
        {
            if (healthbar)
            {
                healthbar.onDamage2(5);
            }
        }
    }


} // class
