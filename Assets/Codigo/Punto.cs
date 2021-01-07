using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punto : MonoBehaviour


    //mecanica implementada a los puntos para que una vez sean recogidos desaparezcan de la pantalla.

{
    bool disappear = false;
    float multiplier = 2.5f;
    SpriteRenderer sprite;

    private void Start() {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {
        if (disappear == true) {
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, sprite.color.a - Time.deltaTime * multiplier);
            if (sprite.color.a < 0f) {
                Destroy(gameObject);
            }
        }    
    }

    public void Disable() {
        if (disappear == false) {
            disappear = true;
        }
    }

    public bool isDisabled() {
        return disappear;
    }
}
