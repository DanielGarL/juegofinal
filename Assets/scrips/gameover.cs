using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public void cambiarescena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
    public void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene("GameOver");
        }
    }
}
