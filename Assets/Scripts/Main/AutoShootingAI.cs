using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShootingAI : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float shootingTime;
    [SerializeField] private Transform shootPoint;

    void Start()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(shootingTime);

        float bulletRotationY = transform.rotation.eulerAngles.y;
        Quaternion bulletRotation = Quaternion.Euler(0f, bulletRotationY, 0f);
        GameObject b1 = Instantiate(bullet, shootPoint.position, bulletRotation);

        print("sds");
        StartCoroutine(Shoot());
    }
}

