using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float begin;
    public float dist = 5;
    public float speed = 5;
    public int dir;

    

    void Start () 
    {
        begin = transform.position.x;
        dir = 1;
        
    }
     void Update()
     {   
         // you should'nt need a non-kinetic rigidbody attached for this simple movement!!!
        if(transform.position.x > begin+dist)
            {
                dir = -1;
                transform.eulerAngles = new Vector3(0f,180f,0f); 
            }
        else
        {
            if(transform.position.x < begin-dist)
            {
                dir = 1;
                transform.eulerAngles = new Vector3(0f,0f,0f); 
            }
        
        }
 
         transform.position = new Vector3 (transform.position.x + Time.deltaTime * speed * dir, transform.position.y, transform.position.z);
        
     }
}
