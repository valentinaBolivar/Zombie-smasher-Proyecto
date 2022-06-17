using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nube_Movimiento : MonoBehaviour
{
    private float velocidadMovimiento = 2;
    public Transform[] puntosMovimiento;
    private float distanciaMin = 1;
    private int enOrden = 0;
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[enOrden].position, velocidadMovimiento * Time.deltaTime);
        if (Vector2.Distance(transform.position, puntosMovimiento[enOrden].position) < distanciaMin)
        {
            enOrden += 1;
            if (enOrden >= puntosMovimiento.Length)
            {
                enOrden = 2;
            }

        }
    }
}
