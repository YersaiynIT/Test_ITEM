using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealItem : Item
{
    [SerializeField] private int _healIncrease;

    public override bool CanPickUpFor(GameObject owner)
    {
        return owner.GetComponent<Health>() != null;
    }

    public override void Use(GameObject owner)
    {
        base.Use(owner);

        Health health = owner.GetComponent<Health>();

        health.Increase(_healIncrease);
    }
}
