using UnityEngine;

public class ShootingModule : MonoBehaviour
{
    [SerializeField] private Projectile projectilePrefab;
    [SerializeField] private Transform weaponTip;
    [SerializeField] private ProjectilePool projectilePool;


    public void Shoot()
    {
        Projectile pooledProjectile = projectilePool.RetrieveFromAvailableList();
        pooledProjectile.transform.position = weaponTip.position;
        pooledProjectile.transform.rotation = weaponTip.rotation;
        pooledProjectile.gameObject.SetActive(true);
        pooledProjectile.StartBullet();
    }
}