using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private ParticleSystem _useEffectPrefab;

    public abstract bool CanPickUpFor(GameObject owner);

    public virtual void Use(GameObject owner)
    {
        Instantiate(_useEffectPrefab, owner.transform.position + Vector3.up, Quaternion.identity, null);
    }
}
