using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteEvent : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Execute(int projectileCode, Vector3 position)
    {
        Debug.Log("Clicked and executed " + projectileCode + " successfully at " + position.x);
    }
}
