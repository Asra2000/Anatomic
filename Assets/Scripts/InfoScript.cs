using UnityEngine;
using UnityEngine.UI;

public class InfoScript : MonoBehaviour
{
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private GameObject generalInfo;
    [SerializeField] private GameObject heartInfo;
    [SerializeField] private GameObject skullInfo;
    [SerializeField] private GameObject menu;
    [SerializeField] private RawImage r_modal;

    private Texture[] modal;

    private void Start() {
        modal =  Resources.LoadAll<Texture>("textures");
        Debug.Log(r_modal);
    }
    public void PanelDisplay(){
        infoPanel.SetActive(!infoPanel.activeInHierarchy);
    }
    public void displayModal()
    {
        menu.SetActive(!menu.activeInHierarchy);
        Debug.Log("called");
    }
    public void infoModal(){
        displayModal();
        r_modal.texture = modal[1];
    }
     public void heartModal(){
        displayModal();
        r_modal.texture = modal[0];
    }
      public void skullModal(){
        displayModal();
        r_modal.texture = modal[2];
    }
}
