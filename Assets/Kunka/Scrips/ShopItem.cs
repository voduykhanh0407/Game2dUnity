using UnityEngine;

[CreateAssetMenu(menuName = "Shop/ShopItem")]

public class ShopItem : ScriptableObject
{
    public Sprite sprite;
    public string itemName;
    public int cost;
    public Color backGroundColor;
}
