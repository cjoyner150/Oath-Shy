using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Void Event", menuName = "Void Event")]
public class VoidEventSO : ScriptableObject
{
    public UnityAction onEventRaised;

    [ContextMenu("Raise Event")]
    public void RaiseEvent()
    {
        onEventRaised?.Invoke();
    }
}
