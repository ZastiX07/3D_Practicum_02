using System;
using UnityEngine;

public class GlobalEventManager : MonoBehaviour
{
    public static Action OnCounterView;
    public static Action OnRightClicked;

    public static void CounterView()
    {
        OnCounterView?.Invoke();
    }

    public static void RightClicked()
    {
        OnRightClicked?.Invoke();
    }
}