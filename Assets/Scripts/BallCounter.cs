using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BallCounter : MonoBehaviour
{
    public Text counterTxt;
    private int ballCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ballCount++;
            UpdateCounterText();
        }
    }

    void UpdateCounterText()
    {
        if (counterTxt != null)
        {
            counterTxt.text = "Counter : " + ballCount;
        }
    }
}
