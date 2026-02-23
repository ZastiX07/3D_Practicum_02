using System;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;

    private void OnEnable()
    {
        _counter.OnValueChanged += CounterValueView;
    }

    private void OnDisable()
    {
        _counter.OnValueChanged -= CounterValueView;
    }

    private void CounterValueView()
    {
        Debug.Log($"Ñ÷¸ò÷èê: {_counter.Value}");
    }
}