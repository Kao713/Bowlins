using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlLanzamiento : MonoBehaviour
{
    private Camera cam;

    public GameObject bola;
    private Rigidbody2D bolaRB;
    private SpringJoint2D bolaSpringJoint;
    public Rigidbody2D pivote;

    private bool arrastrando;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        bolaRB = bola.GetComponent<Rigidbody2D>();
        bolaSpringJoint = bola.GetComponent<SpringJoint2D>();
        bolaSpringJoint.connectedBody = pivote;
        arrastrando = false;
        bolaRB.isKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (bolaRB == null) return;

        if (Touchscreen.current.primaryTouch.press.isPressed)
        {
            arrastrando = true;
            bolaRB.isKinematic = true;

            //Donde se ha pulsado
            Vector2 posicion = Touchscreen.current.primaryTouch.position.ReadValue();
            //Debug.Log("posicion" + posicion + "*");
            Vector3 posicionGlobal = cam.ScreenToWorldPoint(posicion);

            //Control bola y pivote
            bolaRB.position = posicionGlobal;
        }

        //Se ha presionado?
        else
        {
            if (arrastrando == false)
            {
                return;
            }
            else
            {
                
                Invoke("LanzaBola", 0.1f);
                arrastrando = false;
            }

        }

    }

    private void LanzaBola()
    {
        bolaRB.isKinematic = false;
        bolaRB = null;

        Invoke("CortarCuerda", 0.2f);
    }

    private void CortarCuerda()
    {

        bolaSpringJoint.enabled = false;
        bolaSpringJoint = null;
    }
}
