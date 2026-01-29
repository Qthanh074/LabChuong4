using UnityEngine;
using UnityEngine.Video; // Phải có thư viện này mới điều khiển được Video

public class VideoKeyControl : MonoBehaviour
{
    private VideoPlayer vPlayer;

    void Start()
    {
        vPlayer = GetComponent<VideoPlayer>();
    }

    void Update()
    {
        // Nhấn phím V để phát Video
        if (Input.GetKeyDown(KeyCode.V))
        {
            vPlayer.Play();
            Debug.Log("Video đang chạy bằng phím V!");
        }
    }
}