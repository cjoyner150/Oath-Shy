using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionOnTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent action;
    [SerializeField] bool triggerOnce;

    bool canTrigger = true;

    private void OnTriggerEnter(Collider other)
    {
        if (!canTrigger) return;

        if (other.CompareTag("Player"))
        {
            action.Invoke();

            if (triggerOnce) canTrigger = false;
        }
    }
}
