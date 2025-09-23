using UnityEngine;
using UnityEngine.Events;

public class VoidEventListener : MonoBehaviour
{
    [SerializeField] private VoidEventSO _channel = default;
    [SerializeField] private bool activateOnce = false;

    public UnityEvent OnEventRaised;

    private bool activated;

    private void OnEnable()
    {
        if (_channel != null) _channel.onEventRaised += Respond; ;
    }
    private void OnDisable()
    {
        if (_channel != null) _channel.onEventRaised -= Respond; ;
    }

    private void Respond()
    {
        if (activateOnce && activated) return;

        OnEventRaised?.Invoke();
        activated = true;
    }
}