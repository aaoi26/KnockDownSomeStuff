using UnityEngine;
using UnityEngine.InputSystem;

public class BallControler : MonoBehaviour
{
    //public Rigidbody ballPrefab;
    //public float throwPower = 10f;
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //this.ballPrefab = GetComponent<Rigidbody>();
//        Shoot(new Vector3(0, 200, 2000));
    }
    //void OnCollisionEnter(Collision other)
    //{}

    // Update is called once per frame
    void Update()
    {
        //ballPrefab.AddForce((transform.forward+transform.up) * throwPower, ForceMode.Impulse);

    }
    
}
