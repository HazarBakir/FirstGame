using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restarDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()   
    {
        gameHasEnded = true;
        Invoke("Restart", restarDelay);
    }

    void Restart()
    {
        /*SceneManager.LoadScene("Level01");*/
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
