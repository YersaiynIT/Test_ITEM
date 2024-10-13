using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;

    [SerializeField] private Vector3 _offset;
    private void Update()
    {
        Vector3 direction = _target.position - transform.position;

        Vector3 desiredDirection = direction + _offset;

        transform.Translate(desiredDirection * _speed * Time.deltaTime);

        //transform.position = Vector3.Lerp(transform.position, desiredDirection, _speed * Time.deltaTime);
    }
}
