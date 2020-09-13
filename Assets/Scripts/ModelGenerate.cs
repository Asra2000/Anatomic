using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class ModelGenerate : MonoBehaviour
{
    public GameObject btn;
    public Transform buttonHolder;
    Texture[] imgTexture;
    private GameObject[] models;
    private GameObject currentGameObject = null;

    public GameObject ring;
    // Start is called before the first frame update
    void Start()
    {
        imgTexture = Resources.LoadAll<Texture>("Image");
        models = Resources.LoadAll<GameObject>("Model");
        int index = 0;  
        foreach(Texture img in imgTexture)
        {
            GameObject ModelButton = Instantiate(btn as GameObject);
            ModelButton.transform.SetParent(buttonHolder);
            ModelButton.GetComponent<RawImage>().texture = img;
            // index = System.Array.IndexOf(imgTexture, img);
            ModelButton.GetComponent<Button>().onClick.AddListener(() => onModelChange(System.Array.IndexOf(imgTexture, img)));
        }

    }

    public void onModelChange(int index)
    {
        GameObject modelname = models[index];
        Destroy(currentGameObject);
        // if(GameObject.FindGameObjectWithTag("heart")!= null)
        // {
        //     go = GameObject.FindGameObjectWithTag(modelname);
        // }
        if(modelname != null)
        {
            // if(!modelname.activeSelf)
            // {
            //     // modelname.SetActive(true);
                // modelname.transform.position = ring.transform.position;
                currentGameObject = Instantiate(modelname, ring.transform.position , Quaternion.identity);
            // }
            // else
            // {
            //     modelname.SetActive(false);
            // }
           
        }
    }
}
