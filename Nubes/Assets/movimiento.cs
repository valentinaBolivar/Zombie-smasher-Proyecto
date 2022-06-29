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
   // public Animator animacion;
  
    //Muerte
    public float vida;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[enOrden].position, velocidadMovimiento * Time.deltaTime);
        if (Vector2.Distance(transform.position, puntosMovimiento[enOrden].position) < distanciaMin)
        {
            enOrden += 1;
            if(enOrden >= puntosMovimiento.Length)
            {
                enOrden = 2;
            }
        }
    }
    private void OnMouseDown()
    {
        spawn.Instance.marcador++;

        vida--;
        if (vida <= 0)
        {
            GetComponent<CapsuleCollider2D>().enabled = false;
            velocidadMovimiento = 0;
            //animacion.SetBool("muerte", true);
            sprite[0].SetActive(false);
            sprite[1].SetActive(true);

            if(sprite[1] == true)
            {
                Destroy(gameObject, 4f);
            
            }
            
        }
        
    }

    /*public void MyOnDestroy() 
    {
        Destroy(gameObject);
    }
    */
}

