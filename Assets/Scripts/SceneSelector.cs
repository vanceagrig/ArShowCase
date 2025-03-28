using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSelector : MonoBehaviour
{
    // Update is called once per frame
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
