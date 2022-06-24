using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    //Game Over
    public TMP_Text Text;
    public string perder;

    private void Update()
    {
        Puntaje();
    }
    void Start()
    {
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
            //Destroy(gameObject, 5f);
        }
    }
    void Puntaje()
    {
        texto.text = marcador.ToString();

    }
    void Perder()
    {
       
    }
}
