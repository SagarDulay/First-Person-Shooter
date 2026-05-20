using UnityEngine;

public class Projectile : MonoBehaviour
{
    public ProjectilePool poolParent;

    [SerializeField] private float projectileSpeed;


    private Rigidbody projectileRigidbody;


    private void Awake()
    {
        projectileRigidbody = GetComponent<Rigidbody>();
    }
    public void StartBullet()
    {     
        Invoke("ResetBullet", 10f);
        projectileRigidbody.linearVelocity = transform.forward * projectileSpeed;
    }


    public void ResetBullet()
    {
        projectileRigidbody.linearVelocity = Vector3.zero;
        projectileRigidbody.angularVelocity = Vector3.zero;

        poolParent.SendBackToAvailable(this);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        ResetBullet();
    }
}
