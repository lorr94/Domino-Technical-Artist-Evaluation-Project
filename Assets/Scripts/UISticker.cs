using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class UISticker : MonoBehaviour
{

    [SerializeField]
    private SpriteAtlas _spriteAtlas;
    [SerializeField]
    private string _spriteName;
    
    public GameObject _confirmationMenu;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = _spriteAtlas.GetSprite(_spriteName);
        _confirmationMenu = GameObject.Find("Confirmation_Window");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StickerClicked()
    {
        Debug.Log("Sticker Selected!");
        //set active to all children of _confirmationMenu gameObject

        for (int i = 0; i < _confirmationMenu.transform.childCount; i++)
        {
            Transform child = _confirmationMenu.transform.GetChild(i);

            // Set the child GameObject active
            child.gameObject.SetActive(true);
        }
    }
}
