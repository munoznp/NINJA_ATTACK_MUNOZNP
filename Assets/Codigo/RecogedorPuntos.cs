using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogedorPuntos : MonoBehaviour


//mecanicas para la recoleccion de puntos con un colider y a su vez la actualicación de Actualizarpuntos.


{
    private void OnTriggerEnter2D(Collider2D collision) {
        
        if (collision.GetComponent<Punto>() != null) {
            Punto CS = collision.GetComponent<Punto>();
            if (CS.isDisabled() == false) {
                collision.GetComponent<Punto>().Disable();
                GetComponentInParent<Jugador>().controladorNivel.ActualizarPuntos(1);
            }
        }
    }
}
