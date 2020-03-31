using UnityEngine;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{

    public Text wrongWord1;
    public Text wrongWord2;
    public Text wrongWord3;

    public int maxWrongCnt = 3;

    void Start() 
    {
        wrongWord1.text = PlayerPrefs.GetString("question0") + " แปลว่า \n" + PlayerPrefs.GetString("correct0").Substring(3);
        wrongWord2.text = PlayerPrefs.GetString("question1") + " แปลว่า \n" + PlayerPrefs.GetString("correct1").Substring(3);
        wrongWord3.text = PlayerPrefs.GetString("question2") + " แปลว่า \n" + PlayerPrefs.GetString("correct2").Substring(3);

        //Debug.Log(PlayerPrefs.GetString("correct0"));
    }
}
