using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   

    //   public GameObject ss ; 
    //   public SpriteRenderer sss;
    
    
    //color of the car when it  takes a package 
    [SerializeField] Color32 haspackageColor = new Color32(255,255,255,255);
    
    // color of the car when it  deliver  a package or there is no package 

    [SerializeField] Color32 nopackageColor = new Color32(255,255,255,255);
    [SerializeField] float destroyDelay = 1f;
    bool hasPackage = false ;

    SpriteRenderer spriteRenderer= new SpriteRenderer();
    // here  you make a spriteRenderer refrence to some where loc in memory (making a new object  )


  void Start() {

      spriteRenderer= GetComponent<SpriteRenderer>();

       //   ss.GetComponent<SpriteRenderer>().color=new Color32(213,22,44,64);
       //   sss.color= new Color32(213,22,44,64);
}

 void OnCollisionEnter2D(Collision2D other)
{

Debug.Log("Ouch!");


    
}


private void OnTriggerEnter2D(Collider2D other) {

if (other.tag== "Package" && hasPackage == false)
{
Debug.Log("package picked up");
hasPackage=true;
spriteRenderer.color = haspackageColor;

Destroy(other.gameObject,destroyDelay);



}

if (other.tag== "Customer" && hasPackage == true)
{
Debug.Log("package Delivered");
hasPackage=false;
spriteRenderer.color = nopackageColor;
Destroy(other.gameObject,destroyDelay);

}





}

}
