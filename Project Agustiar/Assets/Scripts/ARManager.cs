using UnityEngine;

public class ARManager : MonoBehaviour
{
    // Tambah variabel lain kalau memang diperlukan

    void Start()
    {
        // Tidak ada inisialisasi khusus
    }

    void Update()
    {
        // Kalau nanti butuh logic per-frame, taruh di sini
    }

    public void ChoiceShoes(int idShoes)
    {
        PlayerPrefs.SetInt("SelectedShoes", idShoes);
    }

    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void ExitApp()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
