using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aleatorio : MonoBehaviour
{
    public float vel;
    public Vector2 direc;
    

    private void Start()
    {
        direc = new Vector2(0, -1);
        transform.position = new Vector2(Random.Range(-2.41f, 2.38f), 6.7f);

      
    }

    private void Update()
    {
        transform.Translate(direc * vel * Time.deltaTime);
        
    }


}
