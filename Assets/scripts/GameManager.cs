using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManager manager;
    public int score=0;
	public int lives=3;
    public Text scoreText;
	public bool gameOver=false;
	public GameObject livesPanel;
	public GameObject GameOverPanel;
    private void Awake()
    {
        manager = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increeMentScore()
    {
		if(!gameOver){
		score++;
		scoreText.text=score.ToString();
		}
        
       // print(score);
    }

	public void decreaseLives(){
	if(lives>0){
	lives--;
	livesPanel.transform.GetChild(lives).gameObject.SetActive(false);
	}
	else {
	gameOver=true;
	GameOver();
	}
	}

	public void GameOver(){
	CandySpawner.instance.StopSpawningCandies();
	PlayerController.instance.canMove=false;
	//there can be 2 ways that we can find the gameobject script and then make that variable alter 
	GameOverPanel.gameObject.SetActive(true);
	}

	public void Restart(){
	SceneManager.LoadScene("Game");
	}
	public void BackToMenu(){
	SceneManager.LoadScene("Menu");
	}
    
}
