using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

  public Text scoreText;
  public Text highScoreText;

  public float scoreCount;
   public float highScoreCount;

   public float pointsPerSecond;

public bool scoreIncreasing;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update(){
if(scoreIncreasing){
    scoreCount += pointsPerSecond * Time.deltaTime;
}

    if(scoreCount > highScoreCount){
        highScoreCount = scoreCount;
        PlayerPrefs.SetFloat("highScore" , highScoreCount);
    }
        scoreText.text = "Score : " + Mathf.Round (scoreCount);
        highScoreText.text = " High Score :  " + Mathf.Round(highScoreCount) ;

    }


    }
