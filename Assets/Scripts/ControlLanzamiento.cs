using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlLanzamiento : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se ha presionado?
        if(!Touchscreen.current.primaryTouch.press.isPressed)
        {
            return;
        }
        Debug.Log("Presionado");

        //Donde se ha pulsado
        Vector2 posicion = Touchscreen.current.primaryTouch.position.ReadValue();
    }
}
