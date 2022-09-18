using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void ScreenLoad(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
