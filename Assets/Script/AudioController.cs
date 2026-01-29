using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource myAudio;

    void Start()
    {
        // Lấy component AudioSource từ chính đối tượng này
        myAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Nhấn Space để Play
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAudio.Play();
            Debug.Log("Đang phát nhạc nè");
        }

        // Nhấn S để Stop
        if (Input.GetKeyDown(KeyCode.S))
        {
            myAudio.Stop();
            Debug.Log("Đã dừng nhạc.");
        }
    }
}