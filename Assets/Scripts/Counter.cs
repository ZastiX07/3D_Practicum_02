using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _interval = 0.5f;

    private int _value;

    private Coroutine _coroutine;

    private void OnMouseDown()
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
    
    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator IncreaseValue()
    {
        while(true)
        {
            _value++;

            Debug.Log($"Ñ÷¸ò÷èê: {_value}");

            yield return new WaitForSeconds(_interval);   
        }
    }
}