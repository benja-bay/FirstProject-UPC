using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculadorametodo : MonoBehaviour
{
    class suma{
        public int Sumar(int a, int b)
            {
                return a + b;
            }
        }
    class resta{
        public int Restar(int a, int b)
            {
                return a - b;
            }
        }
    class multip{
        public int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }
    class division{
        public int Dividir(int a, int b)
            {
                return a / b;
            }
        }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("suma: " + suma + "\nresta: " + resta + "\nmultilicacion: " + multip + "\ndivision: " + division + " resto: " + resto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
