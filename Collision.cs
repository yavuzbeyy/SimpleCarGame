using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deliver : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package")
        {
            
        }

         if(other.tag == "Customer")
        {
            
        }
    }
}
