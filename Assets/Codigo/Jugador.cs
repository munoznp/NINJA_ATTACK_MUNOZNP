using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jugador : MonoBehaviour


    //Script sobore el movimiento del jugador en escena, con un sistema de fisicas implementado.

{
    public ControladorNivel controladorNivel;

    float velocidadMaxima = 2f;
    float aceleracion = 2f;
    float velocidadActual;

    Vector3 direccionMovimiento;

    Rigidbody2D rb;

    void Start()
    {
        controladorNivel = GameObject.Find("ControladorNivel").GetComponent<ControladorNivel>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f) {
            if (velocidadActual < velocidadMaxima) {
                if (velocidadActual + aceleracion * Time.deltaTime <= velocidadMaxima) {
                    velocidadActual += aceleracion * Time.deltaTime;
                }
                else {
                    velocidadActual = velocidadMaxima;
                }
            }

            direccionMovimiento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f).normalized;
        }
        else {
            if (velocidadActual > 0f) {
                if (velocidadActual - aceleracion * Time.deltaTime >= 0f) {
                    velocidadActual -= aceleracion * Time.deltaTime;
                }
                else {
                    velocidadActual = 0f;
                }
            }

            if (velocidadActual <= 0f) {
                direccionMovimiento = Vector3.zero;
            }
        }

        rb.velocity = direccionMovimiento * velocidadActual;
    }
}
