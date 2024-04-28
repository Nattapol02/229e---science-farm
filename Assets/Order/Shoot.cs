using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] Transform ShootPoint;
    [SerializeField] Rigidbody2D bulletPrefabs;
    [SerializeField] GameObject Target;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin , ray.direction *10f , Color.magenta , 8f);
 
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit.collider != null) 
            {
                Target.transform.position = new Vector2(hit.point.x, hit.point.y);
                Debug.Log($"hiut point: ({hit.point.x},{hit.point.y})");
 
                Vector2 projectile = CalculateProjectileVelocity(ShootPoint.position , hit.point , 1f);
                Rigidbody2D firedBullet = Instantiate(bulletPrefabs , ShootPoint.position , Quaternion.identity);
                firedBullet.velocity = projectile;
            }
        } 
    }
    Vector2 CalculateProjectileVelocity(Vector2 origin , Vector2 target , float t ) 
    {
        Vector2 distance = target - origin;
 
        float velocityX = distance.x /t;
        float velocityY = distance.y / t + 0.5f * Mathf.Abs(Physics2D.gravity.y) * t;
        Vector2 result = new Vector2 (velocityX, velocityY);
        return result;
    }
 
 
}
