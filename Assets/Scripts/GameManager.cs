using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject navMenu;
    [SerializeField] private GameObject infoBtn;
    public void Start(){
        navMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void Enter(){
        mainMenu.SetActive(false);
        navMenu.SetActive(true);
        infoBtn.SetActive(true);
    }
    private void Update() {
         if (Input.GetMouseButtonDown(0)) {
             Enter();
        }
    }

}
