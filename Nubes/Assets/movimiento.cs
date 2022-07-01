using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float velocidadMovimiento;
    public Transform[] puntosMovimiento;
    public float distanciaMin;
    private int enOrden = 0;
    private SpriteRenderer spriteRenderer;
    public GameObject[] sprite;
    private AudioSource SonidoM;
    // public Animator animacion;

    //Muerte
    public float vida;

    void Start()
    {
        SonidoM = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
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
        curvaDif();
    }
    private void OnMouseDown()
    {
        spawn.Instance.marcador++;
       
        vida--;
        if (vida <= 0)
        {
            SonidoM.Play();
            GetComponent<CapsuleCollider2D>().enabled = false;
            sprite[0].SetActive(false);
            sprite[1].SetActive(true);
            if (sprite[1] == (true))
            {
                velocidadMovimiento = 0;
            }
           
            if (sprite[1] == true)
            {
                Destroy(gameObject, 0.2f);
               
            }

        }


    }
    public void curvaDif()
    {
        if (spawn.Instance.marcador >= 10)
        {
            velocidadMovimiento = velocidadMovimiento + 00.5f * Time.deltaTime;
        }
        if (spawn.Instance.marcador >= 30)
        {
            velocidadMovimiento = velocidadMovimiento + 00.5f * Time.deltaTime;
        }
    }
}

