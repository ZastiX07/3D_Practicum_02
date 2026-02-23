using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;

    private void Start()
    {
        GlobalEventManager.CounterView();
    }

    private void OnEnable()
    {
        GlobalEventManager.OnCounterView += CounterValueView;
    }

    private void OnDisable()
    {
        GlobalEventManager.OnCounterView -= CounterValueView;
    }

    private void CounterValueView()
    {
        Debug.Log($"Ñ÷¸ò÷èê: {_counter.Value}");
    }
}