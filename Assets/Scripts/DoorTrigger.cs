using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;



    private void OnTriggerEnter()
    {
        ForceOpenDoor();
        
    }

    private void OnTriggerExit()
    {
        ForceCloseDoor();
        
    }
    private void ForceOpenDoor()
    {
        doorAnimator.SetBool("IsOpen", true);
    }

    private void ForceCloseDoor()
    {
        doorAnimator.SetBool("IsOpen", false);
    }
}
