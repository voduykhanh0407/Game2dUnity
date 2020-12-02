using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public static int idCharacter;
    public int selectedCharacterIndex;
    private Color desireColor;

    [Header("List of characters")]
    [SerializeField] private List<CharacterSelectionObject> charactersList = new List<CharacterSelectionObject>();

    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI characterName;
    [SerializeField] private TextMeshProUGUI characterText;
    [SerializeField] private Image characterSplash;
    [SerializeField] private Image backgroundColer;

    [Header("Tweaks")]
    [SerializeField] private float backgroundColorTransitionSpeed = 10.0f;

    private void Start()
    {
        UpdateCharacterSelectionUI();
    }

    private void Update()
    {
        backgroundColer.color = Color.Lerp(backgroundColer.color, desireColor, Time.deltaTime * backgroundColorTransitionSpeed);
    }

    public void LeftArrow()
    {
        selectedCharacterIndex--;
        if (selectedCharacterIndex < 0)
        {
            selectedCharacterIndex = charactersList.Count - 1;
        }
        UpdateCharacterSelectionUI();
    }

    public void RightArrow()
    {
        selectedCharacterIndex++;
        if (selectedCharacterIndex == charactersList.Count)
        {
            selectedCharacterIndex = 0;
        }
        UpdateCharacterSelectionUI();
    }

    public void ConFirm()
    {
        idCharacter = selectedCharacterIndex;
        SceneManager.LoadScene("map2.1");
    }

    private void UpdateCharacterSelectionUI()
    {
        characterSplash.sprite = charactersList[selectedCharacterIndex].splash;
        characterName.text = charactersList[selectedCharacterIndex].characterName;
        characterText.text = charactersList[selectedCharacterIndex].CharacterText;
        desireColor = charactersList[selectedCharacterIndex].characterColor;
    }
    [System.Serializable]
    public class CharacterSelectionObject
    {
        public Sprite splash;
        public string CharacterText;
        public string characterName;
        public Color characterColor;
    }

}
