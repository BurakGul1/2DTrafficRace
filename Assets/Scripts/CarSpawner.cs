using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _npcCar;
    private bool canSpawn = true;
    void Start()
    {
        StartCoroutine(Waiting());
    }

    IEnumerator Waiting()
    {
        while (canSpawn)
        {
            Instantiate(_npcCar, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }
}
