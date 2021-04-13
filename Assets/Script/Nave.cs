using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    [SerializeField]
    float maxRelativeVelocity = 2f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Debug.Log("Aterrei");

        }
        else
        {
            Debug.Log("Explodi");
        }


    }
}
    
