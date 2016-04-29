using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    //the score text in ui
    public Text scoreText;
    //the health text in ui
    public Text healthText;
    //the sound to be played when damage is taken
    public AudioSource damageSound;
    //the sound to be played when a gameover occurs
    public AudioSource gameOver;
    //the ship object to be destroyed on game over
    public GameObject ship;
    //
    public GameObject gameOverUI;
    //the image to show on game over
    //public Image gameOverImage;
    //the button to show on game over
    //public Button gameOverButton;

    //the current health
    public int _totalHealth = 20;
    //the total points
    //i planned to use PlayerPrefX but decided not to since I ran out of time and skipped this portion
    private int _totalPoints = 0;

    /// <summary>
    /// Can be called from other classes to add points
    /// </summary>
    public void AddRingPoints()
    {
        //add 100 points
        _totalPoints += 100;
        //set the score in ui
        SetScore();
    }

    /// <summary>
    /// Can be called to from other classes to add points on defeat of enemies
    /// </summary>
    public void AddEnemyPoints()
    {
        //add 200 points and set in ui
        _totalPoints += 200;
        SetScore();
    }

    /// <summary>
    /// Set the score in the ui
    /// </summary>
    protected void SetScore()
    {
        scoreText.text = _totalPoints.ToString();
    }

    //can be called from outside the class to cause the player to take damage
    public void TakeDamage()
    {
        //play the damage sound
        damageSound.Play();
        //subtract a point of health
        _totalHealth -= 1;
        //set in the ui
        SetHealth();
        //if health is 0
        if(_totalHealth == 0)
        {
            //move ui down
            gameOverUI.transform.localPosition = new Vector3(0, 0, 0);
            //play sound
            gameOver.Play();
            //destroy the ship
            Destroy(ship);
            Destroy(gameObject, 2.0f);
            //in 4 seconds call Die function
            //Invoke("Die", 4);
        }
    }

    /// <summary>
    /// Sets the health in the UI
    /// </summary>
    protected void SetHealth()
    {
        healthText.text = _totalHealth.ToString();
    }

    /// <summary>
    /// Loads the game over scene
    /// </summary>
    protected void Die()
    {
        SceneManager.LoadScene("GameOver");   
    }
}
