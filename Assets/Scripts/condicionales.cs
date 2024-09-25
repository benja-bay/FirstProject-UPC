using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condicionales : MonoBehaviour
{
    public int x;
    public int y;
    public int z;
    // Start is called before the first frame update
    void Start()
    {
        if (x == 0 )
            {
                Debug.Log("Numero neutral");
            }
        else
        {
            if (x>0)
            {
                Debug.Log("Positivo");
            }
            else
            {
                Debug.Log("Negativo");
            }
        }
    
    switch(y)
    {
        case 0: 
            Debug.Log("Numero neutral");
            break;
        case > 0:
            Debug.Log("Positivo");
            break;
        default:
            Debug.Log("Negativo");
            break;
    }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
