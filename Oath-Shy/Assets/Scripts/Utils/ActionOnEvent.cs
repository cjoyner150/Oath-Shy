using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionOnEvent : MonoBehaviour
{
    [SerializeField] protected VoidEventSO eventSO;
    [SerializeField] protected UnityEvent action;

    private void OnEnable()
    {
        eventSO.onEventRaised += TriggerAction;
    }

    private void OnDisable()
    {
        eventSO.onEventRaised -= TriggerAction;
    }

    protected virtual void TriggerAction()
    {
        action.Invoke();
    }
}
