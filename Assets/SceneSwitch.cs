using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public void Switch(string SceneName)
    {
        Debug.Log(SceneName);
        SceneManager.LoadScene(SceneName);
    }
}
