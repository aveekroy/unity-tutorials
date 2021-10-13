using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded=false;

    public void GameOver()
    {
        if (gameHasEnded == false) { 
            gameHasEnded = true;
            Debug.Log("GAME OVER!!!");
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
