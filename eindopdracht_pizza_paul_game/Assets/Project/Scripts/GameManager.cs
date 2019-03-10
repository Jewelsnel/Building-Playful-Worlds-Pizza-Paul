using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameIsWon = false;
    bool gameHasEnded = false;

    public float sceneLoadDelay = 1f;



    public void GameIsWon()
    {
        if (gameIsWon == false)
        {
            gameIsWon = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
        


    public void GameHasEnded()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            
        }




    }
            
}
