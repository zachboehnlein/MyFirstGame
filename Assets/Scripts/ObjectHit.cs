using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //On Collision is a callback so whenver collision event takes place
    //That will trigger an event
    //So when walls get hit - we are saying what happens when collision occurs 
    //Privte -- can only be used within this class
    private void OnCollisionEnter(Collision other)
    {  
      if(other.gameObject.tag == "Player")
      {
      GetComponent<MeshRenderer>().material.color = Color.red;
      gameObject.tag = "Hit";
      }
    }
}
