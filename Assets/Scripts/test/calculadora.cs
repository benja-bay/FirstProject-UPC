using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculadora : MonoBehaviour
{
    public int firstValue;
    public int secondValue;
    
    // Start is called before the first frame update
    void Start()
    {
        int suma = (firstValue+secondValue);
        int resta = (firstValue-secondValue);
        int multilicacion = (firstValue*secondValue);
        int division = (firstValue/secondValue);
        int resto = (firstValue%secondValue);

        Debug.Log("suma: " + suma + "\nresta: " + resta + "\nmultilicacion: " + multilicacion + "\ndivision: " + division + " resto: " + resto);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
