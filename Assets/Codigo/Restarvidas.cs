using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restarvidas : MonoBehaviour

    //script para las monedas implementado para bajar vidas cada vez que entras en contacto con el.

{
    void OnTriggerEnter2D(Collider2D col)
    {
        GameControlScript.health -= 1;
    }
}
