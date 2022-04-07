using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    public float producto1;
    public float producto2;
    public float producto3;
    public float dinerodisponible;
    float dineronecesario;
    float dinerosobrante;
    // Start is called before the first frame update
    void Start()
    {
        dineronecesario = producto1 + producto2 + producto3;
        dinerosobrante = dinerodisponible - dineronecesario;

        if(dinerodisponible>dineronecesario)
        {
            Debug.Log("el dinero es suficiente, sobran $"+ dinerosobrante);
        }

        else if(dineronecesario>dinerodisponible)
        {
            Debug.Log("No es suficiente el dinero que posee, le falta $"+dinerosobrante);
        }

        else if(dinerodisponible==dineronecesario)
        {
            Debug.Log("Es suficiente, no le sobra plata");
        }


    
   
    }
}


