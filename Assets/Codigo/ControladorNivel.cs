using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorNivel : MonoBehaviour

    //script utilizado para contabilizar los puntos que el usuario va recogiendo, cuando el usuario colisiona con un punto este queda eliminado y por tando dado al Actualizarpuntos


{
    int puntos = 0;

    TMPro.TMP_Text ContadorPuntos;

    private void Start() {
        ContadorPuntos = GameObject.Find("ContadorPuntos").GetComponent<TMPro.TMP_Text>();
        ActualizarPuntos(0);
    }

    public void ActualizarPuntos(int points) {
        this.puntos += points;

        ContadorPuntos.text = "Puntos: " + this.puntos;
    }

}
