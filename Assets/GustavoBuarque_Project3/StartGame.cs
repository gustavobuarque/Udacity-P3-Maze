using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
    public void Begin(string sceneName)
    {
        // Reset the scene when the user clicks the sign post
        SceneManager.LoadScene(sceneName);
    }
}
