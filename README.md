# InteractWith3DObjectsUsingGestures-MagicLeap-Unity
Detect touches to 3d objects in the Magic Leap Simulator with Unity
//more detailed tutorial available at: http://codeofcodehall.co.uk/magic-leap/interact-with-3d-objects-using-gestures-in-magic-leap-unity/

1. Create New Magic Leap Project in Unity
2. Import the libs folder from the Magic Leap Unity Examples package
3. Create a 3d Cube (Assets > 3D > Cube)
4. Set the position of the cube to 0,2,3
5. Set the rotation to 0,65,0
6. Add a Rigidbody to the cube
7. Disable Use Gravity on the Rigidbody
8. Add the TouchCubeCollider.cs to the cube (Add Component > Scripts > TouchCubeCollider.cs)

9. Create an Empty Game Object and rename it to Gestures
10. Add the GestureDetection.cs script to Gestures
11. Create a 3d Sphere as a child of Gestures
12. Reset the transform on the sphere
13. Set the scale to 0.2, 0.2, 0.2
14. Add a Rigidbody to the sphere
15. Disable use gravity
16. Set the public variable Finger on the Gestures script to the sphere in the unity inspector.


Play! You should see a white cube in the simulator, set the gesture to either the L or the Finger gesture and alter the positions to 0,2,2.4 to touch the cube. The cube should turn blue and react to the collision by moving and rotating.
