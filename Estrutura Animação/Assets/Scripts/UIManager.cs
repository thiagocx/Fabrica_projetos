using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TMP_Text txtScore;
   

    public int score = 0;
  
    
    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SetScore(int value)
    {
        score += value;
        txtScore.text = score.ToString();
     }
    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
