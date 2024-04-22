using UnityEngine;

public class BulletControlScripts : MonoBehaviour
{
    public GameObject BulletObjects;
    private float BulletSpeed = 200;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject bullet = (GameObject)Instantiate(BulletObjects, transform.position, Quaternion.identity);
            Rigidbody ballrigidbody = BulletObjects.GetComponent<Rigidbody>();
            ballrigidbody.AddForce(transform.forward * BulletSpeed);
            Destroy(bullet, 1);
        }
    }
}
