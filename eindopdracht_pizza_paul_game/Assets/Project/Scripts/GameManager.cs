using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameIsWon = false;
    bool gameHasEnded = false;
 

    public float sceneLoadDelay = 1f;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
           
            SceneManager.LoadScene(1);
        }


    }

    public void GameIsWon()
    {
        if (gameIsWon == false)
        {
            gameIsWon = true;
            SceneManager.LoadScene(2);
            

            
        }
        
    }
        


    public void DeathByCar()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            SceneManager.LoadScene(3);
            
        }
    }

    public void Fired()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            SceneManager.LoadScene(4);


        }
    }

}
