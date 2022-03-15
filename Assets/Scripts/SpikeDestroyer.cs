using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Spike")
        {
            Destroy(collision.gameObject);
        }
        
    }




    




}
