using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameMaster.Instance.respawnPoint = transform.position;
        GetComponent<Animator>().SetBool("Taken", true);
    }
}
