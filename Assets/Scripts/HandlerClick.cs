using System;
using System.Collections;
using UnityEngine;

public class HandlerClick : MonoBehaviour
{
    public event Action OnRightClicked;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            OnRightClicked?.Invoke();
    }
}