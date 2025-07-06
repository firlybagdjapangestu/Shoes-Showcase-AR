using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShoesPanelAR : MonoBehaviour
{
    [SerializeField] private ShoesSO[] shoesSO;
    [SerializeField] private TextMeshProUGUI shoesName;
    [SerializeField] private TextMeshProUGUI shoesDescription;
    [SerializeField] private Image[] showCase;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip shoesSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SelectedShoes();
    }

    void SelectedShoes()
    {
        int selectedShoes = PlayerPrefs.GetInt("SelectedShoes");
        if (selectedShoes >= 0 && selectedShoes < shoesSO.Length)
        {
            shoesName.text = shoesSO[selectedShoes].shoesName;
            shoesDescription.text = shoesSO[selectedShoes].shoesDescription;
            shoesSound = shoesSO[selectedShoes].shoesSound;

            for (int i = 0; i < showCase.Length; i++)
            {
                if (i < shoesSO[selectedShoes].showCase.Length)
                {
                    showCase[i].sprite = shoesSO[selectedShoes].showCase[i];
                }
                else
                {
                    showCase[i].sprite = null; // Clear if no more sprites available
                }
            }
        }
    }
    public void PlaySound()
    {
        if (audioSource != null)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
            else if (shoesSound != null)
            {
                audioSource.clip = shoesSound;
                audioSource.Play();
            }
        }
    }
}
