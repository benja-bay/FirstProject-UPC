using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class suerficieyvolumen : MonoBehaviour
{
    // Ejercitacion
        // Crea un programa en C# para calcular la superficie y el volumen de una esfera, dado su radio.
        // suerficie 4 * pi * radio al cuadrado
        // volumen 4/3 * pi * radio al cubo
        public int radio;
        float pi = 3.14f;
    
    // Start is called before the first frame update
    void Start()
    {
        float superficie = 4 * pi * (radio * radio);
        float volumen = (4/3) * pi * (radio * radio * radio);
        Debug.Log("superficie: " + superficie);
        Debug.Log("volumen: " + volumen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
