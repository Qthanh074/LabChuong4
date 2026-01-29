using UnityEngine;

public class GlobalAudioController : MonoBehaviour
{
    private bool isMuted = false;
    private bool isPaused = false;

    void Update()
    {
        // 1. Phím M: Mute/Unmute (Dùng AudioListener.volume)
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted; // Đảo trạng thái true/false
            
            if (isMuted) {
                AudioListener.volume = 0f; // Tắt tiếng hoàn toàn
                Debug.Log("Đã Mute toàn bộ âm thanh");
            } else {
                AudioListener.volume = 1f; // Bật tiếng lại mức tối đa
                Debug.Log("Đã Unmute");
            }
        }

        // 2. Phím P: Pause/Resume (Dùng AudioListener.pause)
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            AudioListener.pause = isPaused; // Tạm dừng tất cả nguồn phát
            
            if (isPaused) {
                Debug.Log("Đã Pause toàn bộ âm thanh");
            } else {
                Debug.Log("Đã Resume");
            }
        }
    }
}