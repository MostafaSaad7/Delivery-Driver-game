using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

   [SerializeField] float steerSpeed=270f; // turning speed 
   [SerializeField] float moveSpeed=18f; // move  speed 
   [SerializeField] float slowSpeed=15f; // speed  when  slowdown 
   [SerializeField] float boostSpeed=30f; //  speed when boost our car 
    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")*steerSpeed * Time.deltaTime;// if we push left arrow we get -1 -- right arrow 1 
        float moveAmount = Input.GetAxis("Vertical")*moveSpeed * Time.deltaTime;
        // Time .DeltaTime makes every thing frame indpendant 
        transform.Rotate(0,0,-steerAmount);

        transform.Translate(0,moveAmount,0);
        
    }


      void OnTriggerEnter2D(Collider2D other) {

          if( other.tag=="Boost")
          moveSpeed=boostSpeed;
        
    }


    private void OnCollisionEnter2D(Collision2D other) {
        
        //    moveSpeed=slowSpeed;
          if( other.gameObject.tag=="Bump")
          moveSpeed=slowSpeed;
    }
}
