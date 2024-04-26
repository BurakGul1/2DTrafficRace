using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _way;
    private bool _createWay = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("MainCar") && _createWay == false)
        {
            Vector3 _spawnLocation = new Vector3(transform.position.x, transform.position.y + 10, 0);
            Instantiate(_way, _spawnLocation, Quaternion.identity);
            _createWay = true;
            Destroy(this.gameObject, 7f);
        }
    }
}
