using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;

    private void OnTriggerEnter()
    {
        doorAnimator.SetBool("IsOpen", true);
    }

    private void OnTriggerExit()
    {
        doorAnimator.SetBool("IsOpen", false);
    }
}
