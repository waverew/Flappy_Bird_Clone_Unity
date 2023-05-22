using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMiddleTrigger : MonoBehaviour
{   public ScoreScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision){
        logic.updateScore(1);
    }
}
