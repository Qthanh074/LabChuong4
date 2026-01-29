using UnityEngine;
using UnityEngine.Video;

public class VideoEndUI : MonoBehaviour
{
    public VideoPlayer vPlayer;
    public GameObject endPanel; // Kéo cái Panel vào đây

    void Start()
    {
        // Đăng ký sự kiện khi video chạy hết
        vPlayer.loopPointReached += ShowEndUI;
    }

    void ShowEndUI(VideoPlayer source)
    {
        // Hiện thông báo lên màn hình
        endPanel.SetActive(true);
        Debug.Log("Video đã kết thúc - Hiện UI thành công!");
    }
}