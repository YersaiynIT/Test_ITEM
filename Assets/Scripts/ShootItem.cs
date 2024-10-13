using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootItem : Item
{
    [SerializeField] private Bullet _bulletPrefab;

    public override bool CanPickUpFor(GameObject owner)
    {
        return owner.GetComponentInChildren<ShootPoint>() != null;
    }

    public override void Use(GameObject owner)
    {
        base.Use(owner);

        Transform shootPoint = owner.GetComponentInChildren<ShootPoint>().transform;

        Bullet bullet = Instantiate(_bulletPrefab, shootPoint.position, Quaternion.identity, null);
        bullet.Launch(shootPoint.forward);
    }

}
