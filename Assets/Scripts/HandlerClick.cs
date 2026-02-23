using System.Collections;
using UnityEngine;

public class HandlerClick : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private float _interval = 0.5f;

    private Coroutine _coroutine;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            GlobalEventManager.RightClicked();
    }

    private void OnClickedMouse()
    {
        if (_coroutine == null)
            _coroutine = StartCoroutine(IncreaseValue());
        else
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }

    private void OnEnable()
    {
        GlobalEventManager.OnRightClicked += OnClickedMouse;
    }

    private void OnDisable()
    {
        GlobalEventManager.OnRightClicked -= OnClickedMouse;
    }

    public IEnumerator IncreaseValue()
    {
        while (true)
        {
            _counter.ExtendValue();

            yield return new WaitForSeconds(_interval);
        }
    }
}