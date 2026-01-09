using UnityEngine;
using UnityEngine.InputSystem;

public class BallGenerator : MonoBehaviour
{
    public GameObject ballPrefab;
    public float ballPower = 2000;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.press.wasPressedThisFrame)
        {
            Vector3 cameraPos = Camera.main.transform.position;
//            GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);// as GameObject;

            GameObject ball = Instantiate(ballPrefab, cameraPos, Quaternion.identity) as GameObject;
            
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            Vector3 worldDir = ray.direction;
            ball.GetComponent<BallControler>().Shoot(worldDir.normalized * ballPower);
        }
    }
}
