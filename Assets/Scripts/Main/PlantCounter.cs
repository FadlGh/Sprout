using UnityEngine;
using TMPro;

public class PlantCounter : MonoBehaviour
{
    void Update()
    {
        GetComponent<TMP_Text>().text = GameMaster.Instance.plantsPlanted.ToString(); 
    }
}
