using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticker : MonoBehaviour
{
    public int stickerIndex;

    public GameObject[] crownInstances;

    // Start is called before the first frame update
    void Start()
    {
        switch (stickerIndex)
        {
                case 1:
                crownInstances[0].SetActive(true);
                break;
                case 2:
                crownInstances[0].SetActive(true);
                crownInstances[1].SetActive(true);
                crownInstances[2].SetActive(true);
                break;
                case 3:
                crownInstances[0].SetActive(true);
                crownInstances[1].SetActive(true);
                crownInstances[2].SetActive(true);
                crownInstances[3].SetActive(true);
                crownInstances[4].SetActive(true);
                break;
                case 4:
                crownInstances[5].SetActive(true);
                crownInstances[6].SetActive(true);
                break;
                case 5:
                crownInstances[5].SetActive(true);
                crownInstances[6].SetActive(true);
                crownInstances[7].SetActive(true);
                crownInstances[8].SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
