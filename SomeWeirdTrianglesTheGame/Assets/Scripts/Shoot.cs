using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    public float bulletSpeed;
    public float shootRate;


    private void Start()
    {
        InvokeRepeating("CmdShoot", 1, shootRate);
    }

    void CmdShoot()
    {
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * bulletSpeed;

        Destroy(bullet, 5.0f);
    }
}
