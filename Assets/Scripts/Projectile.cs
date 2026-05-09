using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float projectileSpeed;
    private Rigidbody projectileRigidbody;


    private void Awake()
    {
        projectileRigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {     
        Invoke("ResetBullet", 10f);
        projectileRigidbody.linearVelocity = transform.forward * projectileSpeed;
    }

    
    void Update()
    {
        
    }

    void ResetBullet()
    {
        Destroy(gameObject);
    }

}
