using UnityEngine;

[CreateAssetMenu(fileName = "ShoesSO", menuName = "Scriptable Objects/ShoesSO")]
public class ShoesSO : ScriptableObject
{
    public string shoesName;
    [TextArea(3, 10)]
    public string shoesDescription;
    public Sprite shoesSprite;
    public AudioClip shoesSound;
    public GameObject shoesPrefab;
}
