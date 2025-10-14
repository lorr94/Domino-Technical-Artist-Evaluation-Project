using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerGeneration : MonoBehaviour
{

    public RectTransform[] placementParents;

    public GameObject stickerPrefab;

    private readonly int[] possibleIndices = { 1, 2, 3, 4, 5 };

    // Start is called before the first frame update
    void Start()
    {



        foreach (RectTransform parent in placementParents)
        {
            Debug.Log("Got Transform for " + parent + "from " + this);
            GameObject newStickerObj = stickerPrefab;
            Instantiate(newStickerObj, parent);
            Sticker stickerComponent = newStickerObj.GetComponent<Sticker>();

            if (stickerComponent != null)
            {
                // Randomly select one of the 5 crown configurations (index 1 to 5)
                int randomIndex = Random.Range(0, possibleIndices.Length);
                stickerComponent.stickerIndex = possibleIndices[randomIndex];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
