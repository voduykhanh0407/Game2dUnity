using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    public static string itName;

    [Header("List of items sold")]
    [SerializeField] private ShopItem[] shopItem;

    [Header("References")]
    [SerializeField] private Transform shopContainer;
    [SerializeField] private GameObject shopItemPrefab;

    private void Start()
    {
        PopulateShop();
    }
    
    private void PopulateShop()
    {
        for (int i = 0; i < shopItem.Length; i++)
        {
            ShopItem si = shopItem[i];
            GameObject itemObject = Instantiate(shopItemPrefab, shopContainer);

            itemObject.GetComponent<Button>().onClick.AddListener(() => onButtonClick(si));
            itemObject.GetComponent<Image>().color = si.backGroundColor;
            itemObject.transform.GetChild(0).GetComponent<Image>().sprite = si.sprite;
            itemObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = si.itemName;
            itemObject.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = si.cost.ToString();
        }
    }

    private void onButtonClick(ShopItem item)
    {
        if (Money.money >= item.cost)
        {
            itName = item.itemName;
            Money.money -= item.cost;
        }
        else
        {
            Debug.Log("Khong du tien");
        }
        
    }
}
