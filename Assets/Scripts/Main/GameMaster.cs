using UnityEngine.SceneManagement;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] private GameObject winUi;

    public static GameMaster Instance;
    public int plantsPlanted = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (plantsPlanted >= 10)
        {
            if (!winUi) return;
            winUi.SetActive(true);
        }   
    }

    public void KillPlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        plantsPlanted = 0;
    }
}
