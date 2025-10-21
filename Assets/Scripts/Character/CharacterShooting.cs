using UnityEngine;

public class CharacterShooting : MouseClickStrategy
{
    [SerializeField] private Transform weaponTip;
    [SerializeField] private BulletPooling poolOfBullets;

    public void Awake()
    {
        if (poolOfBullets == null)
        {
            poolOfBullets = FindAnyObjectByType<BulletPooling>();
        }

    }

    public override void ExecuteStrategy()
    {
        Shoot();
    }

    public void Shoot()
    {
        BulletScript newBullet = poolOfBullets.GetAvailableBullet();

        if (newBullet == null)
        {
            return;
        }

        newBullet.transform.position = weaponTip.position;
        newBullet.transform.rotation = weaponTip.rotation;
        newBullet.gameObject.SetActive(true);
    }

}
