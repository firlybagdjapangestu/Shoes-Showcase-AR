using UnityEngine;
public enum ShoesMerk
{
    Nike,
    Vans,
    Converse
}

[CreateAssetMenu(fileName = "ShoesSO", menuName = "Scriptable Objects/ShoesSO")]
public class ShoesSO : ScriptableObject
{
    public string shoesName;
    [TextArea(3, 10)]
    public string shoesDescription;
    public float minPrice;
    public float maxPrice;
    public Sprite shoesSprite;
    public AudioClip shoesSound;
    public GameObject shoesPrefab;
    public Sprite[] showCase;
    public ShoesMerk shoesMerk;
}
