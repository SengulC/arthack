using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public GameObject splatterMaskObject;
    public GameObject spiralBGObject;

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
                SplatterMask(position);
                break;
            case 1:
                SpiralBG(position);
                break;
            default:
                break;
        }
    }

    void SplatterMask(Vector3 position)
    {
        Instantiate(splatterMaskObject, position, Quaternion.identity);
    }

    void SpiralBG(Vector3 position)
    {
        Instantiate(spiralBGObject, position, Quaternion.identity);
    }
}
