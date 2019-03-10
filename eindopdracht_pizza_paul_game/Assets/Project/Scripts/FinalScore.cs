using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    Text finalAmount;


    void Start()
    {
        finalAmount = GetComponent<Text>();

    }



    public void Update()
    {
        finalAmount.text = "" + Score.scoreAmount;
    }
}
