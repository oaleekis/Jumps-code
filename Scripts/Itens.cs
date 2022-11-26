using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itens : MonoBehaviour
{
    
    int score;

    public GameObject[] puzzle;

    void Start()
    {
        puzzle = GameObject.FindGameObjectsWithTag("puzzle");
        puzzle[0].SetActive(false);
    }

   
    void Update()
    {
        
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            score++;
            Destroy(gameObject);
        }
            puzzle[0].SetActive(true);
    }
}
