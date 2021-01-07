using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPausa : MonoBehaviour


    //script utilizado para pausar el juego y acceder al canvas que nos lleva al menu de pausa.


{

    [SerializeField] GameObject PauseMenu;



    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

            PausarJuego();
    }

    public void PausarJuego()
    {
        if (Time.timeScale == 1)
        {

            Time.timeScale = 0;
            PauseMenu.SetActive(true);

        }

        else
        {

            Time.timeScale = 1;
            PauseMenu.SetActive(false);
        }

    }



}
