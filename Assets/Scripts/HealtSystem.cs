using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtSystem : MonoBehaviour
{
    public int healt = 100;
    public int regen = 5;
    public int damage = 10;
    public int maxHealt = 100;
    public int healtWarning = 20;
 
 
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            // recibe daño 
            GetDamage();
            Debug.Log("Vida actual: " + healt);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            // regeneracion
            GetHeal();
            Debug.Log("Vida actual: " + healt);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (ItsAlive() == false)
            {
                // revivir
                Revive();
                Debug.Log("Se revivio al jugador");
            }
            else
            {
                Debug.Log("No se puede revivir");
            }
            Debug.Log("Vida actual: " + healt);
        }
 
    }
 
    private void GetDamage()
    {
        healt -= damage;
        if (healt <= 0)
        {
            healt = 0;
        }
        HealtWarning();
    }
    private void GetHeal()
    {
        healt += regen;
        if (healt >= maxHealt)
        {
            healt = maxHealt;
        }
        HealtWarning();
    }
    private void Regenerate()
    {
        healt = maxHealt;
    }
    private bool ItsAlive()
    {
        if (healt == 0)
        {  
            return false;
        }
        return true;
 
    }
    private void Revive()
    {
        healt = maxHealt;
    }
    private void HealtWarning()
    {
        if (healt <= healtWarning)
        {
            Debug.Log("La vida es muy baja");
        }
    }
}
