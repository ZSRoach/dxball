using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class scoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    public GameObject ball;
    int score = 0;

    public void addScore(int input){
        if (input == 1){
            score=score+input;
            if (score>=6){ // for testing purpose
                winText.text = "You Win!";
                ball.SetActive(false);
                SceneManager.LoadScene("Level2");
            }
            else{ scoreText.text = score.ToString()+" Points";}
        }
        else if (input == 0){
            winText.text = "Game Over!";
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
