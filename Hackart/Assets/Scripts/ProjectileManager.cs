using System.Runtime.CompilerServices;
using System.Xml.Schema;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
 {
     public int speed = 5;
     public float timer = 5;
     public GameObject projectile;
     private GameObject projectileClone, newProjectClone;
     private Vector3 location;
     private GameObject[] projectiles;
     public float minX, maxX;
     public bool LHS;
 
     void Start ()
     {
         name = LHS ? "Projectile LHS" : "Projectile RHS";
         projectile = GameObject.Find(name);
         // projectile = GameObject.Find("projectile");
     }
     
     void Update()
     {
         timer -= Time.deltaTime;
         if (timer <= 0f)
         {
             location = new Vector3(Random.Range(minX, maxX), -4, 0);
             projectileClone = Instantiate(projectile, location, transform.rotation);
             if (projectile.transform.position.y < -4.5)
             {
                 Destroy(projectile);
             }
             projectile = projectileClone;
             timer = 2f;
         }
     }

     void CleanupProjectiles()
     {
         projectiles = GameObject.FindGameObjectsWithTag("projectile");
         
         foreach (GameObject pj in projectiles)
         {
             if (pj.transform.position.y < -4.5)
             {
                 Destroy(pj);
             }
         }
     }
 }
