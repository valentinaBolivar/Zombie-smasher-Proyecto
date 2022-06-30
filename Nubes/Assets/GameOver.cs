using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Juego");
    }
    public void Pausa()
    {
        Time.timeScale = 0f;
    }
    public void IrMenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void IrTuto()
    {
        SceneManager.LoadScene("tutorial");
    }
}
