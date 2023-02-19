using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickProjectile : MonoBehaviour
{

    private EventManager eventManager;
    private Projectile projectile;

    // Start is called before the first frame update
    void Start()
    {
        eventManager = GameObject.FindGameObjectWithTag("EventManager").GetComponent<EventManager>();
        projectile = this.GetComponent<Projectile>();
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 3);
    }

    void OnMouseDown()
    {
        //Debug.Log("clicked on projectile");

        eventManager.ExecuteEvent(projectile.projectileCode, this.transform.position);

        Destroy(this.gameObject);
    }
}
