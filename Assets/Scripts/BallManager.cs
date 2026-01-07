using UnityEngine;

public class BallManager : MonoBehaviour
{
    public Rigidbody ballPrefab;
    public float throwPower = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.ballPrefab = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ballPrefab.AddForce((transform.forward+transform.up) * throwPower, ForceMode.Impulse);
    }
}
