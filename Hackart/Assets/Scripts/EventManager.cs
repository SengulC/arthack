using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public GameObject splatterMaskObject;
    public GameObject[] candies;
    public UnityEngine.Color[] colors;
    public GameObject scream;
    public GameObject[] deadPortraits;
    public GameObject spiralBGObject;
    public GameObject tearMaskObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExecuteEvent(int projectileCode, Vector3 position)
    {
        Debug.Log("Clicked and executed " + projectileCode + " successfully at " + position.x);
        switch (projectileCode)
        {
            case 0:
                SpiralBG(position);
                break;
            case 1:
                mask(tearMaskObject, projectileCode, position);
                break;
            case 2:
                gory(projectileCode, position);
                break;
            case 3:
                gory(projectileCode, position);
                break;
            default:
                mask(splatterMaskObject, projectileCode, position);
                break;
        }
    }

    // instantiate: splatter, -spiral, -tearmask, gorysprite
    void SpiralBG(Vector3 position)
    {
        Instantiate(spiralBGObject, position, Quaternion.identity);
    }
    
    void mask(GameObject mask, int projectileCode, Vector3 position)
    {
        if (projectileCode > 4) // splatter for candy
        {
            GameObject maskSplatterObject = Instantiate(mask, position, Quaternion.identity);

            switch (projectileCode)
            {
                case 4:
                    maskSplatterObject.GetComponent<Splatter>().childSpriteRenderer.material.color = colors[0];
                    break;
                case 5:
                    maskSplatterObject.GetComponent<Splatter>().childSpriteRenderer.material.color = colors[1];
                    break;
                case 6:
                    maskSplatterObject.GetComponent<Splatter>().childSpriteRenderer.material.color = colors[2];
                    break;
                case 7:
                    maskSplatterObject.GetComponent<Splatter>().childSpriteRenderer.material.color = colors[3];
                    break;
                case 8:
                    maskSplatterObject.GetComponent<Splatter>().childSpriteRenderer.material.color = colors[4];
                    break;
                case 9:
                    maskSplatterObject.GetComponent<Splatter>().childSpriteRenderer.material.color = colors[5];
                    break;
                case 10:
                    maskSplatterObject.GetComponent<Splatter>().childSpriteRenderer.material.color = colors[6];
                    break;
            }
        }
        else // tear
        {
            Instantiate(tearMaskObject, position, Quaternion.identity);
            Instantiate(scream, position, Quaternion.identity);
        }
    }

    // instantiate dead mona lisa or girl w pearl depending on code
    void gory(int projectileCode, Vector3 position)
    {
        if (projectileCode == 2) 
        {
            Instantiate(deadPortraits[0], position, Quaternion.identity);
        }
        else
        {
            Instantiate(deadPortraits[1], position, Quaternion.identity);
        }
    }
}
