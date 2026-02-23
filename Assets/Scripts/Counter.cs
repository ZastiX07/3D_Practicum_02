using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private HandlerClick _handlerClick;
    [SerializeField] private float _interval;
   
    private int _value = 0;
    
    private Coroutine _coroutine;

    public event Action OnValueChanged;

    public int Value => _value;

    private void OnEnable()
    {
        _handlerClick.OnRightClicked += OnClickedMouse;
    }

    private void OnDisable()
    {
        _handlerClick.OnRightClicked -= OnClickedMouse;
    }

    public void ExtendValue()
    {
        _value++;

        OnValueChanged?.Invoke();
    }

    private void OnClickedMouse()
    {
        if (_coroutine == null)
        {
            _coroutine = StartCoroutine(IncreaseValue());
        }
        else
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }

    public IEnumerator IncreaseValue()
    {
        var wait = new WaitForSeconds(_interval);

        while (true)
        {
            ExtendValue();

            yield return wait;
        }
    }
}