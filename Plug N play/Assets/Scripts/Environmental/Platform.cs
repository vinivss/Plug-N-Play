using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject Player;
    //public GameObject platform;
   

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.LogWarning(other.name);
           Player.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
       
            Debug.LogWarning("Hell no");
        Player.transform.parent = null;
      

    }
}
