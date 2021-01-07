using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Desactivarmuro : MonoBehaviour

    //script utilizado para los cambios de mapa, cuando los puntos son tocados estos desactivan columnas que te permiten pasar a otras zonas.


{

    [SerializeField] GameObject muro;

    
    void Start()
    {

    }

    
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
            muro.SetActive(false);

        
    }


}
