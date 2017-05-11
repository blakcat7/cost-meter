using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
    public class targetData : MonoBehaviour
    {

        public Transform TextTargetName;
        //public Transform Panelmain;
        //public Image Panelmain;

        private GameObject Panelmain;
        private GameObject Panelmain2;
        public float smoothTime = 0.3F;
        private Vector3 velocity = Vector3.zero;


        //public Transform TextDescription;
        //public Transform ButtonAction;
        //public Transform PanelDescription;

        //public AudioSource soundTarget;
        //public AudioClip clipTarget;

        // Use this for initialization
        void Start()
        {
            /////Panelmain.gameObject.SetActive (false);
            //Panelmain = GameObject.FindGameObjectsWithTag("Panelmain");

            Panelmain = GameObject.Find("Panelmain");
            Panelmain2 = GameObject.Find("Panelmain2");
            //Panelmain.gameObject.SetActive(false);
            //add Audio Source as new game object component
            //soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            ////Panelmain.gameObject.SetActive (false);
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            Panelmain.gameObject.SetActive(false);
            Panelmain2.gameObject.SetActive(false);

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

                //Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

                TextTargetName.GetComponent<Text>().text = name;
                //				ButtonAction.gameObject.SetActive(true);
                //				TextDescription.gameObject.SetActive(true);
                //				PanelDescription.gameObject.SetActive(true);



                //If the target name was “zombie” then add listener to ButtonAction with location of the zombie sound (locate in Resources/sounds folder) and set text on TextDescription a description of the zombie
                if (name == "reff")
                {
                    //ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/ZombieLongDeath"); });
                    //                  Vector3 targetPosition = TextTargetName.TransformPoint(new Vector3(0, 5, -10));
                    //                  transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
                    TextTargetName.GetComponent<Text>().text = "";//Microwave Cost usage: 2AED/hour
                    Panelmain2.gameObject.SetActive(true);
                }
                if (name == "mic")
                {
                    //ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/ZombieLongDeath"); });
                    //					Vector3 targetPosition = TextTargetName.TransformPoint(new Vector3(0, 5, -10));
                    //					transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
                    TextTargetName.GetComponent<Text>().text = "";//Microwave Cost usage: 2AED/hour
                    Panelmain.gameObject.SetActive(true);
                }
                //				while (name == "IMG_20170510_123436_01") {
                //					//Panelmane().active = true;
                //					Panelmane.gameObject.SetActive (true);
                //				
                //				}


                ////	if(name == "blenderr"){
                //ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/ZombieLongDeath"); });
                //		Vector3 targetPosition = TextTargetName.TransformPoint(new Vector3(0, 5, -10));
                //					transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 2);



                ////		TextTargetName.GetComponent<Text>().text = "Blender Cost usage: 0.5AED/hour";
                ///	}



                //If the target name was “unitychan” then add listener to ButtonAction with location of the unitychan sound (locate in Resources/sounds folder) and set text on TextDescription a description of the unitychan / robot

                //				if (name == "unitychan")
                //				{
                //					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/HelloBabyGirl"); });
                //					TextDescription.GetComponent<Text>().text = "A robot is a mechanical or virtual artificial agent, usually an electromechanical machine that is guided by a computer program or electronic circuitry, and thus a type of an embedded system.";
                //				}
            }
        }

        //function to play sound
        //		void playSound(string ss){
        //			clipTarget = (AudioClip)Resources.Load(ss);
        //			soundTarget.clip = clipTarget;
        //			soundTarget.loop = false;
        //			soundTarget.playOnAwake = false;
        //			soundTarget.Play();
        //		}
    }
}
