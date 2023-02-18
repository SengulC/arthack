using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class ProjectileMovement : MonoBehaviour {
	
    public Vector3 targetPos;
    public float speed = 10;
    Vector3 startPos, currPos;
	
    void Start() {
        startPos = transform.position;
        currPos = transform.position;
    }
	
    void Update() {
        // Compute the next position -- straight flight
        Vector3 nextPos = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        // Rotate to face the next position, and then move there
        transform.rotation = LookAt2D(nextPos - startPos);
        transform.position = nextPos;
		
        // Do something when we reach the target
        if (nextPos == targetPos)
        {
            targetPos = new Vector3(transform.position.x+5, -100, 0);
            nextPos = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

            // Rotate to face the next position, and then move there
            transform.rotation = LookAt2D(nextPos - transform.position);
            transform.position = nextPos;
        }
    }
	
    void Arrived() {
        // Destroy(gameObject);
        // Debug.Log("reached dest");
    }
    
    static Quaternion LookAt2D(Vector2 forward) {
        return Quaternion.Euler(0, 0, Mathf.Atan2(forward.y, forward.x) * Mathf.Rad2Deg);
    }
}