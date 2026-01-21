using UnityEngine;

public class GroundSensor : MonoBehaviour
{
   public bool isGrouned;
   

  void OnTriggerEnter2D(Collider2D collision)
  {
    if(collision.gameObject.layer == 6)
     {
        isGrouned = true;
     } 

  }


  void OnTriggerStay2D(Collider2D collision)
  {
    if(collision.gameObject.layer == 6)
     {
        isGrouned = true;
     } 
  }


  void OnTriggerExit2D(Collider2D collision)
  {
    if(collision.gameObject.layer == 6)
     {
        isGrouned = false;
     } 
  }






}
