using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_protection : MonoBehaviour
{
    GameObject Hero;
    void Start()
    {
        Hero = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground"){


            Hero.GetComponent<Advanced_Player_movement>().is_grounded = true;



        }
    }



     void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.collider.tag == "Ground"){

            Hero.GetComponent<Advanced_Player_movement>().is_grounded = false;


            
        }
        
    }






    
}
