using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHandler
{
    private Inventory _inventory;
    private GameObject _owner;

    public ItemHandler(Inventory inventory, GameObject gameObject)
    {
        _inventory = inventory;
        _owner = gameObject;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (_inventory.HasItem())
            {
                Item item = _inventory.GetItem();
                item.Use(_owner);
                Object.Destroy(item.gameObject);
            }
            else
            {
                Debug.LogError("Отсутствет предмет!");
            }
        }
    }
}
