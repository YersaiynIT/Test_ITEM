using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostItem : Item
{
    [SerializeField] private float _speedIncrease = 2f;

    private Movement _movement;

    public override bool CanPickUpFor(GameObject owner)
    {
        return owner.GetComponent<Movement>() != null;
    }

    public override void Use(GameObject owner)
    {
        base.Use(owner);

        _movement = owner.GetComponent<Movement>();
        _movement.IncreaseSpeed(_speedIncrease);
    }
}
