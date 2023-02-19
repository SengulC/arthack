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
        bool gore = projectileCode > 3;
        switch (projectileCode)
        {
            case 1:
                SpiralBG(position);
                break;
            case 2:
                mask(tearMaskObject, projectileCode, position);
                break;
            case 30:
                gory(projectileCode, position);
                break;
            case 31:
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
        if (projectileCode < 1) // splatter
        {
            switch (projectileCode)
            {
                case 01:
                    Instantiate(mask, position, Quaternion.identity);
                    GameObject.Find("splatter").GetComponent<SpriteRenderer>().material.color = colors[0];
                    break;
                case 02:
                    Instantiate(mask, position, Quaternion.identity);
                    GameObject.Find("splatter").GetComponent<SpriteRenderer>().material.color = colors[1];
                    break;
                case 03:
                    Instantiate(mask, position, Quaternion.identity);
                    GameObject.Find("splatter").GetComponent<SpriteRenderer>().material.color = colors[2];
                    break;
                case 04:
                    Instantiate(mask, position, Quaternion.identity);
                    GameObject.Find("splatter").GetComponent<SpriteRenderer>().material.color = colors[3];
                    break;
                case 05:
                    Instantiate(mask, position, Quaternion.identity);
                    GameObject.Find("splatter").GetComponent<SpriteRenderer>().material.color = colors[4];
                    break;
                case 06:
                    Instantiate(mask, position, Quaternion.identity);
                    GameObject.Find("splatter").GetComponent<SpriteRenderer>().material.color = colors[5];
                    break;
                case 07:
                    Instantiate(mask, position, Quaternion.identity);
                    GameObject.Find("splatter").GetComponent<SpriteRenderer>().material.color = colors[6];
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
        if (projectileCode == 30) 
        {
            Instantiate(deadPortraits[0], position, Quaternion.identity);
        }
        else
        {
            Instantiate(deadPortraits[1], position, Quaternion.identity);
        }
    }
}
