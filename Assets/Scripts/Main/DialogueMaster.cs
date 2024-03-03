using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class DialogueMaster : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(SwitchScene()); 
    }

    IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(13f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
