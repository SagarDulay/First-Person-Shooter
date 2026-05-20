using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;



    private void OnTriggerEnter()
    {
        ForceCloseDoor();
        
    }

    private void OnTriggerExit()
    {
        ForceCloseDoor();
        
    }
    private void ForceOpenDoor()
    {
        doorAnimator.SetBool("IsOpen", false);
    }

    private void ForceCloseDoor()
    {
        doorAnimator.SetBool("IsOpen", false);
    }
}
