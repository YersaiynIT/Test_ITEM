using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private string HorizontalAxisName = "Horizontal";
    private string VerticalAxisName = "Vertical";

    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    private float _deadZone = 0.1f;

    private CharacterController _characterController;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw(HorizontalAxisName), 0, Input.GetAxisRaw(VerticalAxisName));

        if (input.magnitude <= _deadZone)
            return;

        _characterController.Move(input.normalized * _speed * Time.deltaTime);

        Quaternion lookRotation = Quaternion.LookRotation(input.normalized);
        float step = _rotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
    }

    public void IncreaseSpeed(float speedIncrease)
    {
        _speed += speedIncrease;
    }
}
