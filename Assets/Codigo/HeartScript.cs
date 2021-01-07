using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour

    //senzillo script, para sumar vidas en caso de que fuese necesitario, no implementado por no tener necesidad.

{
    void OnTriggerEnter2D (Collider2D col)
    {
        GameControlScript.health += 1;
    }
}
