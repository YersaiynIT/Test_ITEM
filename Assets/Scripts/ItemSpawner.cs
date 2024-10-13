using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private List<Item> _itemPrefabs;
    [SerializeField] private List<Transform> _spawnPoints;

    private void Start()
    {
        for (int i = 0; i < _itemPrefabs.Count; i++)
        {
            Instantiate(_itemPrefabs[i], _spawnPoints[i].position, Quaternion.identity, null);
        }
    }
}
