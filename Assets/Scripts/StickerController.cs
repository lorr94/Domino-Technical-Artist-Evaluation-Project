using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class StickerController : MonoBehaviour
{
    public StickerData stickerData;

    public SpriteAtlas nameAtlas;

    public Transform crownLayoutPlacement;
    public GameObject crownIconTemplate;
    public List<GameObject> activeCrowns = new List<GameObject>();

    public Transform textLinePlacement;
    public GameObject letterSpriteTemplate; 
    public GameObject dividerTemplate; 
    public Transform textDividerParent; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
