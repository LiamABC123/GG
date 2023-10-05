using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoToScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
    public void ExitApp() {
        Application.Quit();
        Debug.Log("Application has quit.");
    }
}
