using UnityEngine.SceneManagement;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] private GameObject winUi;

    public static GameMaster Instance;
    public int plantsPlanted = 0;
    public Vector3 respawnPoint;

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

        respawnPoint = GameObject.FindWithTag("Player").transform.position;
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
        GameObject.FindWithTag("Player").transform.position = respawnPoint;
        plantsPlanted = 0;
    }
}
