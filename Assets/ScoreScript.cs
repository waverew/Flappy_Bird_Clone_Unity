using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public int score;
    public Text myText;
    [ContextMenu("Increase score")]
    public void updateScore(int points){
        score+= 1;
        myText.text = score.ToString();
    }
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
    public void gameOver(){
        gameOverScreen.SetActive(true);
    }
    
}
