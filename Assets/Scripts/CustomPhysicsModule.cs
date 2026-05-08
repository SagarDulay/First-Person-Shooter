using UnityEngine;

public class CustomPhysicsModule : MonoBehaviour
{

    [SerializeField] private float gravityForce = -9.8f;
    [SerializeField] private LayerMask walkableLayerMask;

    public Vector3 upDownForce;


    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(CustomPhysicsModule.CheckSphere(transform.position, 0.075f, walkableLayerMask))
        {
            upDownForce.y = 0;
        }
        else
        {
            if(upDownForce.y > -10)
            {
                upDownForce.y += gravityForce * Time.deltaTime;
            }
        }
    }

    public void AddForceUpward(float force)
    {
        if(CustomPhysicsModule.CheckSphere(transform.position, 0.075f, walkableLayerMask))
        {
            upDownForce.y = force;
        }
    }


    private void OnDrawGizmos()
    {
        OnDrawGizmos.DrawSphere(transform.position, 0.075f);
    }

}
