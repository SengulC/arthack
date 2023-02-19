using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int projectileCode;
    public SpriteRenderer[] sprites;
    private SpriteRenderer spriteRenderer; 
    // Start is called before the first frame update
    void Start()
    {   
        DetermineProjectileCode();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DetermineProjectileCode()
    {
        int rand = Random.Range(0,11);
        projectileCode = rand;
        spriteRenderer = sprites[projectileCode];
    }

}
