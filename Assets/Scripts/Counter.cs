using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private int _value = 0;

    public int Value => _value;
  
    public void ExtendValue()
    {
        _value++;

        GlobalEventManager.CounterView();
    }
}