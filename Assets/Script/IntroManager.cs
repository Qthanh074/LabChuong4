using UnityEngine;
using UnityEngine.SceneManagement; // Bắt buộc phải có dòng này

public class IntroManager : MonoBehaviour
{
    // Hàm này phải để là 'public' thì cái Nút mới thấy để gọi được
    public void SkipToGameplay()
    {
        SceneManager.LoadScene("Gameplay"); // Tên phải viết hoa/thường y hệt tên Scene bạn đã tạo
        Debug.Log("Đã bấm nút SKIP - Chuyển sang Gameplay!");
    }
}