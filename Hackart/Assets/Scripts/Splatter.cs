using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splatter : MonoBehaviour
{
    private SpriteMask spriteMask;

    public List<Sprite> maskSprites;
    public SpriteRenderer childSpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteMask = this.GetComponent<SpriteMask>();

        ChooseSplatter();
        ChangeOrientation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChooseSplatter()
    {
        Sprite maskSprite = maskSprites[Random.Range(0, maskSprites.Count)];
        spriteMask.sprite = maskSprite;
        childSpriteRenderer.sprite = maskSprite;
    }

    void ChangeOrientation()
    {

    }
}
