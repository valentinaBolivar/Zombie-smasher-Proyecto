using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float segundoSpawn = -0.5f;
    public float bordeMin;
    public float bordeMax;
    public float velocidadJuego = 3;
    void Start()
    {
        StartCoroutine(EnemySpawn());

    }
    IEnumerator EnemySpawn()
    {
        while(true)
        {
            var wanted = Random.Range(bordeMax, bordeMin);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(enemyPrefab[Random.Range(0, enemyPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(segundoSpawn);
            //Destroy(gameObject, 5f);
        }

       

    }
   
}
