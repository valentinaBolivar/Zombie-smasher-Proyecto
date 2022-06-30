using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class spawn : MonoBehaviour
{
    //control
    public static spawn Instance;
    //Spawn
    public GameObject[] enemyPrefab;
    public float segundoSpawn = -0.5f;
    public float bordeMin;
    public float bordeMax;
    public float velocidadJuego = 3;
    //Puntuacion
    public int marcador;
    public TMP_Text texto;
    //vida
    public int vida;
    public TMP_Text textoVida;

    private void Update()
    {
        Vida();
        Puntaje();
    }
    void Start()
    {
        vida = 3;
        marcador = 0;
        StartCoroutine(EnemySpawn());
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    IEnumerator EnemySpawn()
    {
        while (true)
        {
            var wanted = Random.Range(bordeMax, bordeMin);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(enemyPrefab[Random.Range(0, enemyPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(segundoSpawn);
        }
    }
    void Puntaje()
    { 
        texto.text = marcador.ToString();
    }
   void Vida()
    {
        textoVida.text = vida.ToString("vida: " + vida);
            
    }

   
}
