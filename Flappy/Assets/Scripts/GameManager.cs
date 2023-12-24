using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TMP_Text skorText;

    public Image beyaz;

    //gameover panel 
    public GameObject gameOverPanel;
    public TMP_Text gameOverSkorText;

    int skor;
    Player player;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        player = FindObjectOfType<Player>();
    }
    public void GameOver()
    {
        Debug.Log("GameOver");
        PauseGame();
    }
    public void ScoreUp()
    {
        skor++;
        skorText.text = skor.ToString();
    }
    public void PlayGame()
    {
        Time.timeScale = 1f;
        skor = 0;
        skorText.text = skor.ToString();
        gameOverPanel.SetActive(false);
        skorText.gameObject.SetActive(true);
        SetImageActive(true);
        //meteorlarý yok et
        Meteor[] meteor = FindObjectsOfType<Meteor>();
        for(int i=0; i<meteor.Length; i++)
        {
            Destroy(meteor[i].gameObject);
        }

        //ufo yu ortala
        player.transform.position = Vector3.zero;
    }
    public void PauseGame()
    {
        gameOverPanel.SetActive(true);
        skorText.gameObject.SetActive(false);
        gameOverSkorText.text = skor.ToString();
        SetImageActive(false);
        Time.timeScale = 0f;
    }
    void SetImageActive(bool isActive)
    {
        beyaz.enabled = isActive;
    }
}
