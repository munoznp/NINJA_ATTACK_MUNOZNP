using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour



    //script utilizado para acceder al menu principal desde la portada.

{
    
    void Start1()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))

        {

            SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
        }

    }



}
