using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int projectileCode;

    // Start is called before the first frame update
    void Start()
    {
        DetermineProjectileCode();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DetermineProjectileCode()
    {
        float rand = Random.Range(0, 10);
        if (rand >= 7)
        {
            //spiralBG projectile
            projectileCode = 1;
            this.GetComponent<SpriteRenderer>().material.color = Color.blue;
        }
        else
        {
            //paint projectile
            projectileCode = 0;
            this.GetComponent<SpriteRenderer>().material.color = Color.red;
        }

        Debug.Log(rand);
    }
}
