using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject restartText;

    bool gameHasEnded=false;

    public void GameOver()
    {
        if (gameHasEnded == false) { 
            gameHasEnded = true;
            Debug.Log("GAME OVER!!!");
            restartText.SetActive(true);
            // Invoke helps in delaying the function to be called - here 2 seconds delay in calling Restart function
            Invoke("Restart", 2f);
        }
    }

    void Restart()
    {
        //LoadScene - Loads the scene
        //GetActiveScene - Gets the current scene of the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
