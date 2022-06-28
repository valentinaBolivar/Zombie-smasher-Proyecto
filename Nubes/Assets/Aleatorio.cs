using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Aleatorio : MonoBehaviour
{
    public float vel;
    public Vector2 direc;
    public float vida;


    private void Start()
    {
        direc = new Vector2(0, -1);
        transform.position = new Vector2(Random.Range(-2.41f, 2.38f), 6.7f);

      
    }

    private void Update()
    {
        transform.Translate(direc * vel * Time.deltaTime);
        
    }
    private void OnMouseDown()
    {
        
        vida--;
        if (vida <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");

        }
    }

}
