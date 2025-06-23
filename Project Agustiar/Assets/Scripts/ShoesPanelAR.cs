using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShoesPanelAR : MonoBehaviour
{
    [SerializeField] private ShoesSO[] shoesSO;
    [SerializeField] private TextMeshProUGUI shoesName;
    [SerializeField] private TextMeshProUGUI shoesDescription;
    [SerializeField] private Image[] showCase;

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
}
