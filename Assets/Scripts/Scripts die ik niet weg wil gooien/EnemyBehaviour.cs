using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    public float Hitpoint;
    public float maxHitpoints = 5;
    public HealthBarBehaviour Healthbar;


    // Start is called before the first frame update
    void Start()
    {
        Hitpoint = maxHitpoints;
        Healthbar.SetHealth(Hitpoint, maxHitpoints);
    }

    public void TakeHit(float damage)
    {
        Hitpoint -= damage;
        Healthbar.SetHealth(Hitpoint, maxHitpoints);

        if (Hitpoint <= 0 )
        {
            Destroy(gameObject);
        }
    }
}
