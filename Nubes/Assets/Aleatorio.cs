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
    private AudioSource SonidoM;

    private void Start()
    {
        SonidoM = GetComponent<AudioSource>();
        direc = new Vector2(0, -1);
        transform.position = new Vector2(Random.Range(-2.41f, 2.38f), 6.7f);

      
    }

    private void Update()
    {
        transform.Translate(direc * vel * Time.deltaTime);
        curvaDif();
    }
    private void OnMouseDown()
    {
        
        vida--;
        if (vida <= 0)
        {
            SonidoM.Play();
            GetComponent<CapsuleCollider2D>().enabled = false;
            sprite[0].SetActive(false);
            sprite[1].SetActive(true);
            vel = 0;
            if (sprite[1] == true)
            {
                Destroy(gameObject, 0.2f);
            }
            spawn.Instance.vida--;
            if(spawn.Instance.vida == 0)
            {
                SceneManager.LoadScene("GameOver");
            }

        }
    }
    public void curvaDif()
    {
        if (spawn.Instance.marcador >= 10)
        {
            vel = vel + 00.5f * Time.deltaTime;
        }
        if (spawn.Instance.marcador >= 30)
        {
            vel = vel + 00.5f * Time.deltaTime;
        }
    }
}
