
using UnityEngine;

public class playercollision : MonoBehaviour
{
   public playerscript movement;
   void OnCollisionEnter(Collision collisionInfo)
   {
       if(collisionInfo.collider.tag=="obstacle")
       {
           movement.enabled= false;
           FindObjectOfType<gameManager>().EndGame();
           
       }
   }

}
