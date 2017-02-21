# Purpose
These scripts allow you to make a character created with Autodesk Character Generator look happy, sad, angry, 
fearful or surprised.

![Alt text](https://github.com/mariusrubo/Unity-Humanoid-FacialExpressions/blob/master/FacialExpressions.jpg)

# Installation
* The character must have a Skinned Mesh Renderer with facial blendshapes. The script should work plug-and-play for characters from 
Autodesk Character Generator. For other characters, some adjustments may be needed.
* Attach "FacialExpressions.cs" to your character. Drag the character's skin and its teeth to the corresponding transforms in the
inspector's view on the script.
* Attach "FacialExpressionsInterface.cs" to any object in your scene (possibly, but not necessarily the character). Drag your character
to the corresponding transform in the inspector's view on this script. 
* Press play, click on GUI buttons in the game view.

# Extend
* It is possible to adjust the intensity and speed of change of facial expression as well as the frequency of eye blinks. See comments
in scripts for further information. 
* The facial expressions do not yet comform to standards defined in the Facial Action Coding System. Moreover, disgust is stil missing. 
This will be corrected in the future. 

# License
These scripts run under the GPLv3 license.
