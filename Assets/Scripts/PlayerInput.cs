using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    public Vector3 movementDirection;
    [SerializeField] private float lookSensitivity; 
    public Vector3 lookRotationDirection;


    private Camera firstPersonCamera;
    private CharacterController characterController;
    private CustomPhysicsModule customPhysicsModule;


    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        firstPersonCamera = GetComponentInChildren<Camera>();
        customPhysicsModule = GetComponent<CustomPhysicsModule>();
    }

    void Update()
    {
        MoveInput();
        LookInput();
    }

    private void MoveInput()
    {
        movementDirection.x = Input.GetAxisRaw("Horizontal");
        movementDirection.z = Input.GetAxisRaw("Vertical");

        movementDirection = movementDirection.normalized;

        Vector3 forwardDirection = characterController.transform.forward * movementDirection.z;
        Vector3 rightDirection = characterController.transform.right * movementDirection.x;
        Vector3 gravityDirection = customPhysicsModule.upDownForce;

        Vector3 movementInput = forwardDirection + rightDirection;
        Vector3 totalMovement = (movementInput * moveSpeed) + gravityDirection;

        characterController.Move(totalMovement * Time.deltaTime);
    }

    private void LookInput()
    {
        
    }

    private void 

    JumpInput()
    {
        if (input)
    }
}
