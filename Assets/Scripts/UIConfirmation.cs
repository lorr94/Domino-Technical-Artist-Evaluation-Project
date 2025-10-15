using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIConfirmation : MonoBehaviour
{
    public bool isTaken = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isTaken == true)
        {
            //set both red and green buttons inactive
            //can click to collect sticker
            //confirmation menu dissapears
            //isTaken bool back to false
        }
    }



    public void Cancel()
    {
        Destroy(this.gameObject);
    }

    public void TakeSticker()
    {
        Debug.Log("Sticker Taken!");
        isTaken = true;

    }
}
