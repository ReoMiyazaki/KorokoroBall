using UnityEngine;
using UnityEngine.SceneManagement;  // using‚ð–Y‚ê‚È‚¢‚Å

public class GameManager : MonoBehaviour
{
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    private void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
    }

}
