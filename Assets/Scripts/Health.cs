using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int Value { get; private set; }

    public void Initialize(int value)
    {
        Value = value;
    }

    public void Increase(int value)
    {
        if (value < 0)
        {
            Debug.LogError("value < 0");
            return;
        }

        Value += value;

        Debug.Log($"Health: {Value}");
    }

}
