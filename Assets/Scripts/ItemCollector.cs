using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private Inventory _inventory;

    public void Initialize(Inventory inventory)
    {
        _inventory = inventory;
    }

    private void OnTriggerEnter(Collider other)
    {
        Item item = other.GetComponent<Item>();

        if (item == null)
            return;

        if (_inventory.HasItem() == false && item.CanPickUpFor(gameObject))
        {
            _inventory.PutItem(item);
        }
    }

}
