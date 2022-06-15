using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bruja : MonoBehaviour
{
    public float speed = 10.0f;
    public float gravity = 0.1f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, gravity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
