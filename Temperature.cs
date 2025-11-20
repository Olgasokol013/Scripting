using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public Health health;
    public int playerDamage = 2;
    public float temperatureCurrent = 36.6f;
    public float temperatureNormal = 36.6f;
    public float temperatureCritical = 34f;
    public float freezenSpeed = 0.05f;
    public float freezenDamageTimer = 1;
    public float freezenDamageDelay = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temperatureCurrent -= freezenSpeed * Time.deltaTime;
        if (temperatureCurrent <= temperatureCritical)
        {

            if (freezenDamageTimer <= 0)
            {
                health.TakeDamage(playerDamage);
                freezenDamageTimer += freezenDamageDelay;
            }
            else
            { 
            
                freezenDamageTimer -= Time.deltaTime;
            }
            
            
        }
    }
}
