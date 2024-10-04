using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class variables : MonoBehaviour
{
        // variables:
        // como declarar variables: tipoDeDato nombreeDeVariable;
    string hola = "Hola mundo";
        // Ejercitacion
        // 1. Imprimir en la consola un “Hola Mundo” o “Hello World”
        // 2. Declarar 2 variables, nombre y edad, asignarles un valor e imprimirlos en consola
    string name = "Benjamin Bayarri";
    int age = 22;
    public string myName;

    // Start is called before the first frame update
    void Start()
    {
            // imprimir variables 
        Debug.Log(hola);
            // forma 1
        // Debug.Log("Nombre: "name, "Edad: "age);
            // forma 2
        Debug.Log($"Nombre: {name}, Edad: {age}");

        Debug.Log("I am alive and my name is " + myName);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
