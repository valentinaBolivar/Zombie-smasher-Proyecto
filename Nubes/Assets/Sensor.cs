using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {

       
        if (collision.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }

        if (collision.tag == "Human")
        {

            Destroy(collision.gameObject);
        }

    }
}
