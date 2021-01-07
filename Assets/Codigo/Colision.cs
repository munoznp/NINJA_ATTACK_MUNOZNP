using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colision : MonoBehaviour
{
    // Este script es similar a CambiodeNivel solo que al actuar sobre su colider lo que hacemos es que nos lleve directamente a la escena de final de nivel.


    void Start()
    {

    }

    
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Jugador")
        {
            SceneManager.LoadScene("Nivel4", LoadSceneMode.Single);
        }
    }

}