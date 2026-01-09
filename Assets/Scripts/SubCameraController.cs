using UnityEngine;
using UnityEngine.InputSystem;

public class SubCameraController : MonoBehaviour
{
    //回転速度
    public float rotationSpeed = 1f;
    //x軸回転角度の最大値
    public float max_rotation_x = 60f;
    //現在の回転角度
    private float rotation_x = 0f;
    private float rotation_y = 0f;
 
    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.leftArrowKey.isPressed){
            //回転角度を変更
            rotation_y -= rotationSpeed;
            //y軸を軸に左回りにrotationSpeed度回転
            transform.rotation = Quaternion.Euler(rotation_x, rotation_y, 0);
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            //回転角度を変更
            rotation_y += rotationSpeed;
            //y軸を軸に左回りにrotationSpeed度回転
            transform.rotation = Quaternion.Euler(rotation_x, rotation_y, 0);
        }
        else if (Keyboard.current.upArrowKey.isPressed)
        {
            //カメラの縦方向の角度の範囲を指定
            if(rotation_x < -max_rotation_x){
                //範囲外のときreturn
                return;
            }
            //回転角度を変更
            rotation_x -= rotationSpeed;
            //x軸を軸に上方向に回転
            transform.rotation = Quaternion.Euler(rotation_x, rotation_y, 0);
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            //カメラの縦方向の角度の範囲を指定
            if (rotation_x > max_rotation_x)
            {
                //範囲外のときreturn
                return;
            }
            //回転角度を変更
            rotation_x += rotationSpeed;
            //x軸を軸に上方向に回転
            transform.rotation = Quaternion.Euler(rotation_x, rotation_y, 0);
        }
    }
}
