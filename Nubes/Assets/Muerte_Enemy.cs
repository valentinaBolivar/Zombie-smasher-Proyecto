using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte_Enemy : MonoBehaviour
{
    public float vida;

    private void OnMouseDown()
    {
        vida--;
        if (vida <= 0)
        {
            Destroy(gameObject);

            
        }
    }
}
