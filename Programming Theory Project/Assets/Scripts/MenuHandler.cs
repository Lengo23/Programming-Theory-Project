using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    // Method to load the Main scene
    public void Play()
    {
        SceneManager.LoadScene("Main");
    }

    // Method to exit the application
    public void Exit()
    {
        #if UNITY_EDITOR
            // If running in the Unity Editor
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // If running as a standalone build
            Application.Quit();
        #endif
    }
}