using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
     public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

}
