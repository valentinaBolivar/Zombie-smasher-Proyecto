using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Aleatorio : MonoBehaviour
{
    public float vel;
    public Vector2 direc;
    public float vida;
    public GameObject[] sprite;
    public float velocidadMovimiento;
    private AudioSource SonidoM;

    private void Start()
    {
        SonidoM = GetComponent<AudioSource>();
        direc = new Vector2(0, -1);
        transform.position = new Vector2(Random.Range(-2.41f, 2.38f), 6.7f);

      
    }

    private void Update()
    {
        velocidadMovimiento = velocidadMovimiento * Time.deltaTime;
        transform.Translate(direc * vel * Time.deltaTime);
        
    }
    private void OnMouseDown()
    {
        SonidoM.Play();
        vida--;
        if (vida <= 0)
        {
            GetComponent<CapsuleCollider2D>().enabled = false;
            velocidadMovimiento = 0;
            //animacion.SetBool("muerte", true);
            sprite[0].SetActive(false);
            sprite[1].SetActive(true);

            if (sprite[1] == true)
            {
                Destroy(gameObject, 2f);

            }
    
            spawn.Instance.vida--;
            if(spawn.Instance.vida == 0)
            {
                SceneManager.LoadScene("GameOver");
            }

        }
    }

}
