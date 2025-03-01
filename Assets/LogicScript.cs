using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    //public int highScore;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public GameObject startScreen;
    public AudioSource scoreSrc;
    public AudioClip scoreSound;


    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) {
        if (!gameOverScreen.activeInHierarchy) {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
            scoreSrc.clip = scoreSound;
            scoreSrc.Play();
        }
    }

    public void startGame() {
        startScreen.SetActive(false);
    }

    public void restartgame() {
        Debug.Log("Restart Pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        setHighScore(playerScore);
        highScoreText.text = getHighScore().ToString();
        gameOverScreen.SetActive(true);
    }

    private void setHighScore(int finalScore) {
        if (!PlayerPrefs.HasKey("highscore")) {
            PlayerPrefs.SetInt("highscore", finalScore);
            PlayerPrefs.Save();
            return;
        }

        if (PlayerPrefs.GetInt("highscore") < finalScore) {
            PlayerPrefs.SetInt("highscore", finalScore);
        }
        PlayerPrefs.Save();
    }

    private int getHighScore() {
        return PlayerPrefs.GetInt("highscore");
    }
}
