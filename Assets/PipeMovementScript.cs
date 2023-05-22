using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    public float deadPoint = -40;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -40){
            Debug.Log("demolished");
            Destroy(gameObject);
        }
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
