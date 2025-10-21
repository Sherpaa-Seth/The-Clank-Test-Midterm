using Unity.VisualScripting;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private BulletPooling poolOwner;

    //[SerializeField] private BulletPooling bulletPooling;
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private float strength;


    private void OnEnable()
    {
        Invoke("ResetBullet", 5f);
        myRigidbody.AddForce(transform.forward * strength, ForceMode.Impulse);
    }

    public void InitializePooledBullet(BulletPooling Owner)
    {
        poolOwner = Owner;
    }

    private void ResetBullet()
    {
        myRigidbody.linearVelocity = Vector3.zero;
        myRigidbody.angularVelocity = Vector3.zero;

        poolOwner.ReturnBullet(this);

        gameObject.SetActive(false);
    }


}
