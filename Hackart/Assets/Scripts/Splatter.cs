using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splatter : MonoBehaviour
{
    private SpriteMask spriteMask;

    public List<Sprite> maskSprites;
    public SpriteRenderer childSpriteRenderer;

    public float fadeRate;
    public bool keepFading = true;

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
        Color oldColour = childSpriteRenderer.material.color;

        if (keepFading)
        {
            
            childSpriteRenderer.material.color = new Color(oldColour.r, oldColour.g, oldColour.b, oldColour.a - fadeRate * Time.deltaTime);
        }
        else
        {

        }

        if (oldColour.a <= 0)
        {
            Destroy(this.gameObject);
        }
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
