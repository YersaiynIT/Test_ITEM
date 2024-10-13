using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Transform _itemHolerPoint;
    [SerializeField] private ItemCollector _itemCollector;
    [SerializeField] private Health _health;

    private Inventory _inventory;
    private ItemHandler _itemHandler;

    private void Awake()
    {
        _inventory = new Inventory(_itemHolerPoint);

        _itemCollector.Initialize(_inventory);
        _itemHandler = new ItemHandler(_inventory, gameObject);

        _health.Initialize(100);
    }

    private void Update()
    {
        _itemHandler.Update();
    }
}
