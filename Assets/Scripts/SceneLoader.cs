using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public void LoadGame() {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void LoadMenu() {
        SceneManager.LoadScene(0);
    }
}
