using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayScene : MonoBehaviour
{
    [SerializeField] int TotalBugsFixed;
    public Text AmountOfMoney;

    private void Start()
    {
        TotalBugsFixed = PlayerPrefs.GetInt("TotalBugsFixed");
    }

    public void FixBugBtnClick()
    {
        TotalBugsFixed++;
        PlayerPrefs.SetInt("TotalBugsFixed", TotalBugsFixed);
    }

    public void To_Shop()
    {
        SceneManager.LoadScene(1);
    }

    void FixedUpdate()
    {
        AmountOfMoney.text = TotalBugsFixed.ToString();
    }
}
