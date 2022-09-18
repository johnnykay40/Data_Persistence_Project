using UnityEngine;
using TMPro;

public class SaveName : MonoBehaviour
{
    public static SaveName Instance;
    public TMP_InputField inputName;

    public string refInputName;

    private void Awake()
    {
        Instance = this;
        LoadNamePlayer();
    }
    public void EqualsName()
    {
        refInputName = inputName.text;
    }    
    private void LoadNamePlayer()
    {
        refInputName = PlayerPrefs.GetString("DataInputName");
        inputName.text = refInputName;
    }
    private void SaveNamePlayer()
    {
        PlayerPrefs.SetString("DataInputName", refInputName);
    }
    private void OnApplicationFocus(bool focus)
    {
        if (!focus)
        {
            SaveNamePlayer();
        }
    }
}
