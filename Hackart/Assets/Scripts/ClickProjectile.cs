using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickProjectile : MonoBehaviour
{

    private ExecuteEvent executeEvent;
    private Projectile projectile;

    // Start is called before the first frame update
    void Start()
    {
        executeEvent = this.GetComponent<ExecuteEvent>();
        projectile = this.GetComponent<Projectile>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        //Debug.Log("clicked on projectile");

        executeEvent.Execute(projectile.projectileCode, this.transform.position);
    }
}
