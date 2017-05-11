//****** Donations are greatly appreciated.  ******
//****** You can donate directly to Jesse through paypal at  https://www.paypal.me/JEtzler   ******

var letterPause = 0.2;
var sound : AudioClip;
var myText : String = "testtttttttttt" + "\n" + "testttttttttttttt";
 
function Start () {	
    TypeText ();
}
 
function TypeText () {
    for (var letter in myText.ToCharArray()) {
        GetComponent.<GUIText>().text += letter;
        if (sound)
            GetComponent.<AudioSource>().PlayOneShot (sound);
        yield WaitForSeconds (letterPause);
    }		
}