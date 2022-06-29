using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        if (collision.tag == "enemy")
        {
            spawn.Instance.vida--;
            if (spawn.Instance.vida == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }

    }
}
