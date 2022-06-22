using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensor : MonoBehaviour
{
    public float vida;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="enemy")
        {
            Destroy(gameObject);
        }

    }


}
