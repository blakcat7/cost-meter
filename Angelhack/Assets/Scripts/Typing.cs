using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Typing : MonoBehaviour
{
    public GameObject ui;

    /*    Text Scrolling     */
    public GameObject textBox;
    public Text theText;
    public string[] textLines;
    public int currentLine;
    public int endAtLine;
    private bool isTyping = false;
    public float typeSpeed;

    void Start()
    {
        /*    Initalizing animation     */



        /*    Text Scrolling     */
        if (endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }
    }

    void Update(){

        /*    Text Scrolling     */
        theText.text = textLines[currentLine];
        if (!isTyping)
        {
            currentLine += 1;
            if(currentLine > endAtLine)
            {
                DisableTextBox();
            }
            else
            {
                StartCoroutine(TextScroll(textLines[currentLine]));
            }
        }
        /*else if(isTyping && !cancelTyping)
        {
            cancelTyping = true;
        }*/
    }

    private IEnumerator TextScroll(string lineOfText)
    {
        int letter = 0;
        theText.text = "";
        isTyping = true;
        //cancelTyping = false;
        while (isTyping /*&& !cancelTyping*/ && (letter < lineOfText.Length-1))
        {
            theText.text += lineOfText[letter];
            letter += 1;
            yield return new WaitForSeconds(typeSpeed);
        }
        theText.text = lineOfText;
        isTyping = false;
        //cancelTyping = false;
    }

    void DisableTextBox()
    {
        textBox.SetActive(false);
    }

}