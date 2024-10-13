using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private Transform _itemHolderPoint;
    private Item _item;

    public Inventory(Transform itemHolderPoint)
    {
        _itemHolderPoint = itemHolderPoint;
    }

    public bool HasItem() => _item != null;

    public Item GetItem()
    {
        if (HasItem() == false)
        {
            Debug.LogError("Инвентарь пуст!");
            return null;
        }

        
        _item.transform.SetParent(null);
        Item selectedItem = _item;
        _item = null;
        return selectedItem;
    }

    public void PutItem(Item item)
    {
        if (HasItem())
        {
            Debug.LogError("Инвентарь полон!");
            return;
        }

        _item = item;
        _item.transform.SetParent(_itemHolderPoint);
        _item.transform.localPosition = Vector3.zero;
    }


}
