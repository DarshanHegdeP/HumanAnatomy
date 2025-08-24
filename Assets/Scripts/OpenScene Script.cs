using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene(5); // Loads scene at index 1
    }
}
