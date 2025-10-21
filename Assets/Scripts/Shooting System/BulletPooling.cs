using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class BulletPooling : MonoBehaviour
{
    [SerializeField] private BulletScript bulletPrefab;
    [SerializeField] private List<BulletScript> availableBullets = new List<BulletScript>();
    [SerializeField] private List<BulletScript> unavailableBullets = new List<BulletScript>();


    void Awake()
    {
        for (int number = 0; number < 20; number++)
        {
            CreatePooledBullet();
        }
    }

    private void CreatePooledBullet()
    {
        BulletScript bulletClone = Instantiate(bulletPrefab, transform);

        bulletClone.InitializePooledBullet(this);

        bulletClone.gameObject.name = availableBullets.Count.ToString();
        availableBullets.Add(bulletClone);
        bulletClone.gameObject.SetActive(false);
    }

    public BulletScript GetAvailableBullet()
    {
        if (availableBullets.Count == 0)
        {
            CreatePooledBullet();
        }

        BulletScript firstAvailableBullet = availableBullets[0];

        availableBullets.RemoveAt(0);
        unavailableBullets.Add(firstAvailableBullet);

        return firstAvailableBullet;
    }

    public void ReturnBullet(BulletScript usedBullet)
    {
        unavailableBullets.Remove(usedBullet);
        availableBullets.Add(usedBullet);
    }


}
