using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class characterswitch : MonoBehaviour
{
    public Image Gorilla;
    public Image Monkey;
    public Camera cameraison;
    public ClicktoMove isabletomove;

    bool flag;
    // Use this for initialization
    bool inputEnabled = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (inputEnabled == true)
        {
            cameraison.enabled = true;
            isabletomove.enabled = true;
            Gorilla.color = Color.black;
            Monkey.color = Color.white;


        }
        else
        {

            cameraison.enabled = false;
            isabletomove.enabled = false;
            isabletomove.flag = false;
            Monkey.color = Color.black;
            Gorilla.color = Color.white;

        }
    }

    public void Activate()
    {
        inputEnabled = true;
        
    }

    public void Deactivate()
    {
        inputEnabled = false;
       
    }
}
