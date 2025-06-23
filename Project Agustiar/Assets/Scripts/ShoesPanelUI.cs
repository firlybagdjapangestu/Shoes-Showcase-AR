using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShoesPanelUI : MonoBehaviour
{
    [SerializeField] private ShoesSO shoesSO;
    [SerializeField] private TextMeshProUGUI shoesName;
    [SerializeField] private TextMeshProUGUI shoesPrice;
    [SerializeField] private Image shoesImage;
    [SerializeField] private AudioClip shoesSound;
    [SerializeField] private Button shoesSoundButton;
    [SerializeField] private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shoesName.text = shoesSO.shoesName;
        shoesImage.sprite = shoesSO.shoesSprite;
        shoesPrice.text = $"{shoesSO.minPrice}k - {shoesSO.maxPrice}k";
        shoesSound = shoesSO.shoesSound;

        shoesSoundButton.onClick.AddListener(PlaySound);
    }

    void PlaySound()
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
