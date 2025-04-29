using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personalTrainer : MonoBehaviour
{

    public int horasSemanales;
    public string tipoEntrenamiento;
    float precio;


    // Start is called before the first frame update
    void Start()
    {
        if(horasSemanales < 1)
        {
            Debug.Log("El mínimo de horas semanales es 1");
        }else if (horasSemanales > 6)
        {
            Debug.Log("El máximo de horas semanales es 6");
        }else if (tipoEntrenamiento == "Cardio"){
            precio = horasSemanales * 1000;
        }
        else if (tipoEntrenamiento == "Fuerza")
        {
            precio = horasSemanales * 1500;
        }
        else if (tipoEntrenamiento == "Recreativo")
        {
            precio = horasSemanales * 2500;
        }
        
        
        if(tipoEntrenamiento!= "Cardio" && tipoEntrenamiento != "Fuerza" && tipoEntrenamiento != "Recreativo")
        {
            Debug.Log("Tipo de entrenamiento no existe");
        }
        else if(horasSemanales == 6) {
            Debug.Log("Tipo de entrenamiento: " + tipoEntrenamiento);
            Debug.Log("Horas reservadas: " + horasSemanales);
            Debug.Log("Precio sin descuento: " + precio);
            Debug.Log("Precio con descuento: " + precio*90/100);
        }else if (horasSemanales != 6 && horasSemanales <6 && horasSemanales > 0)
        {
            Debug.Log("Tipo de entrenamiento: " + tipoEntrenamiento);
            Debug.Log("Horas reservadas: " + horasSemanales);
            Debug.Log("Precio: " + precio);
        }
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
