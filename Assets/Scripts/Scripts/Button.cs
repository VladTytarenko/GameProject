using System.Collections;
using UnityEngine.Events;
using UnityEngine;

public class Button : MonoBehaviour
{
    public UnityEvent signalOnClick = new UnityEvent();

    public void _onClick()
    {
        this.signalOnClick.Invoke();
    }
}
