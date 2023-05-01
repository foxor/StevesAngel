using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Director : MonoBehaviour {
    protected static Director Instance;
    public GameObject MainMenu;
    public GameObject YouLose;
    public GameObject YouWin;
    public static void OnPlayerDied() {
        Instance.YouLose.SetActive(true);
        Time.timeScale = 0f;
    }
    public static void OnWin() {
        Instance.YouWin.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Awake() {
        Time.timeScale = 0f;
        Instance = this;
    }
    public void Update() {
        if (Input.GetMouseButtonDown(0)) {
            if (MainMenu.activeSelf) {
                MainMenu.SetActive(false);
                Time.timeScale = 1f;
            }
            if (YouWin.activeSelf || YouLose.activeSelf) {
                SceneManager.LoadScene(0);
                Time.timeScale = 1f;
            }
        }
    }
}
