using System.Runtime.CompilerServices;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
 {
     public int speed = 5;
     public float timer = 5;
     public GameObject projectile;
     private GameObject projectileClone;
     private Vector3 location;
     private GameObject[] projectiles;
 
     void Start () 
     {
        projectile = GameObject.Find("Projectile");   
     }
     
     void Update()
     {
         timer -= Time.deltaTime;
         if (timer <= 0f)
         {
             location = new Vector3(Random.Range(-9, 0), -4, 0);
             projectileClone = Instantiate(projectile, location, transform.rotation);
             timer = 2f;
         }

         CleanupProjectiles();
     }

     void CleanupProjectiles()
     {
         projectiles = GameObject.FindGameObjectsWithTag("projectile");
         
         foreach (GameObject pj in projectiles)
         {
             if (pj == projectile || pj.transform.position.y > -4.5)
             {
                 continue;
             }
             Destroy(pj);
         }
     }
 }
