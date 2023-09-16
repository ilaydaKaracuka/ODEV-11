using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform movePoints;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float starTime;
    private float waitTime;
 
    void Start()
    {
        movePoints.position = new Vector3(
            Random.Range(minX, maxX),transform.position.y,
            Random.Range(minZ, maxZ)
        );
        
    }


    void Update()
    {

        
        transform.position = Vector3.MoveTowards(
            transform.position,
            movePoints.position,
            speed * Time.deltaTime
        );

        if (Vector3.Distance(transform.position, movePoints.position) < 0.2f)
        {

            if (waitTime <= 0)
            {
                movePoints.position = new Vector3(
                Random.Range(minX, maxX),transform.position.y,
                Random.Range(minZ, maxZ)
                );
                waitTime = starTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
    
}