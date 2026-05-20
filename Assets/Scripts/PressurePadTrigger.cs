using UnityEngine;
using UnityEngine.Events;

public class PressurePadTrigger : MonoBehaviour
{
    public UnityEvent OnPressureActivate;
    public UnityEvent OnPressureDeactivate;

    public Rigidbody correctRigidbody;


    protected virtual void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody== correctRigidbody)
        {
            OnPressureActivate.Invoke();
        }
    }

    protected virtual void OnTriggerExit(Collider other)
    {
        if(other.attachedRigidbody == correctRigidbody)
        {
            OnPressureDeactivate.Invoke();
        }
    }
}
