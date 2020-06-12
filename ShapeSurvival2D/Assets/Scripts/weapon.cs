using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){

            shoot();


        }

    void shoot(){

       RaycastHit2D hitinfo =  Physics2D.Raycast(firePoint.position,firePoint.right);

       if(hitinfo){




           






       }



        




    } 

   } 
}
