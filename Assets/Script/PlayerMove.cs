using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10f; // Tốc độ di chuyển

    void Update()
    {
        // Lấy tín hiệu từ phím mũi tên hoặc WASD
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Tính toán hướng đi
        Vector3 move = new Vector3(h, 0, v);

        // Di chuyển nhân vật
        transform.Translate(move * speed * Time.deltaTime);
    }
}