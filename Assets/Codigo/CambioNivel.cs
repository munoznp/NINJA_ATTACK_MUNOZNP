using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel : MonoBehaviour

    //Script utilizado para actuar sobre el castillo, cuando el jugador actua sobre su colider este activa el panel de cambio de menu.
    
{


    [SerializeField] GameObject Final;

    
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
         Final.SetActive(true);

        }
    }

}