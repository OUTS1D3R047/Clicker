using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] int TotalCash;
    public Text AmountOfMoney;

    // Start is called before the first frame update
    private void Start()
    {
    	TotalCash = PlayerPrefs.GetInt("TotalCash");
    }

    public void ButtonClick() // Total Cash increases
    {
        TotalCash++;
        PlayerPrefs.SetInt("TotalCash", TotalCash);
    }

    public void To_Shop()
    {
    	SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        AmountOfMoney.text = TotalCash.ToString();
    }
}
