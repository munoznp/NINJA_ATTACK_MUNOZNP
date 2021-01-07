using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


public class FuncionesMenu : MonoBehaviour
{
    // Este script contiene todas las funciones del menú y paneles, son declaradas tambien las funciones rapidas de teclado que llamas a las ejecuciíon con Getkeydown, tambien tenemos implementadas las cargas de nivel.



    void Start()
    {

    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))

            Web();

        if (Input.GetKeyDown(KeyCode.S))

            Quit();

        if (Input.GetKeyDown(KeyCode.C))

            Controls();

        if (Input.GetKeyDown(KeyCode.J))

            Play();

        if (Input.GetKey(KeyCode.Q))

            Quit();




    }







    public void Quit() 
    
    {
        

            Application.Quit();
    }

    public void Play() {
        SceneManager.LoadScene("Nivel1");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menuprincipal");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controles");
    }


    public void Nivel2()
    {
        SceneManager.LoadScene("Nivel2");
    }

    public void Nivel3()
    {
        SceneManager.LoadScene("Nivel3");
    }


    public void Web()
    {

      
        {
            Process.Start(@"https://www.instagram.com/planetcaravanartwork/");


        }

            
    }
}
