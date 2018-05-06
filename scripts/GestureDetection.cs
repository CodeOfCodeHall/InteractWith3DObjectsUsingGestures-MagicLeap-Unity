/*
 * Script: GestureDetection.cs
 * Author: King
 * Site: http://codeofcodehall.co.uk
 * Date: May 6th 2018
 * Lumin SDK: 0.13.0
 * Desc: Setup the gestures we want to track.
 *       When the gesture is detected update 
 *       the position of the hand.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR.MagicLeap;
public class GestureDetection : MonoBehaviour
{
    //game object representing the finger position
    public Transform finger;
    // Use this for initialization
    void Start()
    {
        if (!MLHands.Start())
        {
            Debug.Log("MLHands didn't start...bail.");
            return;
        }
        //set gestures to track
        setGesturesToTrack();
    }

    // Update is called once per frame
    void Update()
    {
        //if MLHands is running start tracking gestures
        if (MLHands.IsStarted)
            gestureTracker();
    }

    //set the gestures to track
    void setGesturesToTrack()
    {
        List<MLStaticGestureType> gestures = new List<MLStaticGestureType>();
        //add the gestures we want to track
        gestures.Add(MLStaticGestureType.Finger);
        gestures.Add(MLStaticGestureType.L);
        //add the gestures to the gesture manager
        MLHands.GestureManager.EnableGestures(gestures.ToArray(), true, true);
    }

    //track the gestures
    void gestureTracker()
    {
        //check for the l or finger gesture
        //and that we've got some keypoints
        if ((MLHands.Left.StaticGesture == MLStaticGestureType.Finger ||
               MLHands.Left.StaticGesture == MLStaticGestureType.L) &&
               MLHands.Left.KeyPoints.Length > 0)
        {
            positionHand(MLHands.Left);
        }
        //check for the l or finger gesture
        //and that we've got some keypoints
        if ((MLHands.Right.StaticGesture == MLStaticGestureType.Finger ||
                MLHands.Right.StaticGesture == MLStaticGestureType.L) &&
                MLHands.Right.KeyPoints.Length > 0)
        {
            positionHand(MLHands.Right);
        }
    }

    //position the game object to the tracked finger
    void positionHand(MLHand hand)
    {
        //in Lumin SDK 0.13 only the center hand position
        //updates so we need to use that until it's fixed
        finger.position = hand.Center;
        //set the finger position to the tip of the finger
        //finger.position = hand[1].position;
    }

    private void OnDestroy()
    {
        MLHands.Stop();
    }
}
