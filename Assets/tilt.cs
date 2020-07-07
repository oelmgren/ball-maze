using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tilt : MonoBehaviour
{
    public GameObject platform;
    public Vector3 currentRot;
    float moveVertical;
    float moveHorizontal;
    double rotateZ;
    double angleFromStraightZ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      rotateZ = platform.transform.localRotation.z;
      print("X rotation" + platform.transform.localRotation.x);
      print("Y rotation" + platform.transform.localRotation.y);
      print("Z rotation" + platform.transform.localRotation.z);
      moveHorizontal = Input.acceleration.x;
      moveVertical = Input.acceleration.y;
      currentRot = GetComponent<Transform> ().eulerAngles;
      // print("Move Horizontal: " + moveHorizontal);
      // print("Move Vertical: " + moveVertical);
      // print("currentRot: " + currentRot);


      // int zRotation = currentRot.z;
      // angleFromStraightZ = Mathf.Abs(360 - zRotation);
      // print("Angle From Straight" + angleFromStraightZ);
      // if ((Input.GetAxis ("Horizontal") > .2) && (currentRot.z <= 10 || currentRot.z >= 348)) {
      //   transform.Rotate(0,0,1);
      // }
      // if((Input.GetAxis ("Horizontal") < -.2) && (currentRot.z <= 11  || currentRot.z >= 349)) {
      //   transform.Rotate(0,0,-1);
      // }
      // if((Input.GetAxis ("Vertical") > .2) && (currentRot.x <= 10  || currentRot.x >= 348)) {
      //   transform.Rotate(1,0,0);
      // }
      // if((Input.GetAxis ("Vertical") < -.2) && (currentRot.x <= 11 || currentRot.x >= 349)) {
      //   transform.Rotate(-1,0,0);
      // }
      // Accelerometer
     
      if((moveHorizontal > .1)  && (currentRot.z < 15  || currentRot.z > 344)) {
        transform.Rotate(0,0,.4f);
      }
      // && (currentRot.x <= 11 || currentRot.x >= 349)

      if((moveHorizontal < -.1) && (currentRot.z < 16  || currentRot.z > 345)) {
        transform.Rotate(0,0,-.4f);
      }
      // && (currentRot.z <= 10 || currentRot.z >= 348)
      if ((moveVertical > .1) && (currentRot.x < 16  || currentRot.x > 345)) {
        transform.Rotate(-.4f,0,0);
      }
      //  && (currentRot.z <= 11  || currentRot.z >= 349)
      if((moveVertical < -.1)&& (currentRot.x < 15  || currentRot.x > 344)) {
        transform.Rotate(.4f,0,0);
      }

    }
}
