using TMPro;
using UnityEngine;

public class ShoesPanelAR : MonoBehaviour
{
    [SerializeField] private ShoesSO[] shoesSO;
    [SerializeField] private TextMeshProUGUI shoesName;
    [SerializeField] private TextMeshProUGUI shoesDescription;

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
        }
    }
}
