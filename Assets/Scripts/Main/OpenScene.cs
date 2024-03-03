using UnityEngine.SceneManagement;
using UnityEngine;

public class OpenScene : MonoBehaviour
{
    public void OpenSceneNumber(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
}
