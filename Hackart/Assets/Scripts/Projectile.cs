using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int projectileCode;
    public List<Sprite> sprites;
    public SpriteRenderer spriteRenderer;

    //public List<int> projectileCodes;

    // Start is called before the first frame update
    void Start()
    {   
        DetermineProjectileCode();
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DetermineProjectileCode()
    {
        int rand = Random.Range(0, 100);

        if (rand <= 5)
        {
            //scream tear
            projectileCode = 1;
        }
        else if (rand <= 12.5)
        {
            //monalisa
            projectileCode = 2;
        }
        else if (rand <= 20)
        {
            //pearl
            projectileCode = 3;
        }
        else if (rand <= 30)
        {
            //starry night spiral
            projectileCode = 0;
        }
        else
        {
            //candy
            projectileCode = Random.Range(4, 10);
        }

        spriteRenderer.sprite = sprites[projectileCode];
    }

}
