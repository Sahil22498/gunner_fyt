using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class playerMovement : MonoBehaviour
{
   
    public playerSelect player;
    public GameObject[] character;
    public Transform PlayerPosition;
     public GameObject playerObject;
    public int selectedCharac;
    Rigidbody2D playerRigid;
  

   
    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody2D>();
        selectedCharac = playerSelect.selectedCharacter;
       // print(selectedCharac+"this is another");
       // player = GameObject.Find(Red2).GetComponent<playerSelect>();
       // selectedCharacter = playerSelect.player.selectedCharacter;
         GameObject playerObject = (GameObject)Instantiate(character[selectedCharac],PlayerPosition.position,character[selectedCharac].transform.rotation);
       
        playerObject.SetActive(true);
        playerObject.transform.localScale = new Vector2(4.3086f, 4.1018f);
        playerObject.GetComponent<Rigidbody2D>().freezeRotation = true;
        playerObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        playerObject.GetComponent<Rigidbody2D>().gravityScale = 15;
        // playerObject.AddComponent<PlayerScript>();






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
