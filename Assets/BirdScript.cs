using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public ScoreScript logic;
    public Rigidbody2D myRigidBody;
    public float flopStrength;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Berber";
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flopStrength;
        }
        if(transform.position.y > 20 || transform.position.y < -20){
            birdIsAlive = false;
            logic.gameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D col){
        birdIsAlive = false;
        logic.gameOver();
    }
}
