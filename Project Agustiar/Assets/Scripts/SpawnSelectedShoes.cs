using UnityEngine;

public class SpawnSelectedShoes : MonoBehaviour
{
    [SerializeField] private ShoesSO[] shoesSO;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SelectedShoes();
    }


    void SelectedShoes()
    {
        int selectedShoes = PlayerPrefs.GetInt("SelectedShoes");
        GameObject spawnedShoes = Instantiate(shoesSO[selectedShoes].shoesPrefab, transform.position, Quaternion.identity);
        spawnedShoes.transform.SetParent(transform);
    }    
}
