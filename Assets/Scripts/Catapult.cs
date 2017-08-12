using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField]
    private GameObject projectileToFire;

    [SerializeField]
    private Transform projectileSpawnTranform;

    public float thrust;
    public Rigidbody projectile;

    private void Start()
    {
        //projectile = GetComponent<Rigidbody>();
    }

    public void Fire()
    {
        Rigidbody clone;
        clone = Instantiate(projectile, projectileSpawnTranform.transform.position, projectileSpawnTranform.transform.rotation) as Rigidbody;   
        clone.AddForce(-Vector3.right * thrust, ForceMode.Impulse);
       // clone.velocity = transform.TransformDirection(Vector3.forward * 10);
    }



    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Fire();
        }
    }
}