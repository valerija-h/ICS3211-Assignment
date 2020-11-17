# The Escape - Creating a VR Escape Room game for the Oculus Quest

For the Intelligent Interfaces 2 (ICS3211) assignment, students were asked to create a prototype of an app that utilizes an intelligent interface. As part of the assessment, each team was also asked to record their planning and design phases on an online blog. Our team decided to create a VR Escape Room game using the Oculus Quest VR headset and Oculus touch controllers. The planning, design, implementation and evaluation process that was carried out when creating our game was recorded in the following <a href="https://valerijaholomjova1.wixsite.com/theescape" target="_blank">blog</a>.

## Concept and Implementation
The game was coded for the Android Platform using Unity and the Oculus Integration package. The package includes scripts, components and VR features to ease the Oculus app development process. Using the package, we have implemented two main gameplay mechanisms - UI interaction (selecting buttons) and object interaction (grabbing, throwing). We decided to implement the game using the Oculus Quest instead of the Oculus Rift as it allows the user to navigate through an open space without using a wire in a safe manner (notifies the user when they leave a safe boundary). The user will need a free space of 4x4 meters to play the prototype since the game mechanisms requires the user to walk around the room in order to interact with objects.

<p align="center"><img src="https://github.com/valerija-h/ICS3211-Assignment/blob/master/Images/Environment.png" width="50%" /></p>
<p align="center"><b>Image 1</b> - The game environment from the Unity Editor</p>

As mentioned in our blog, we created states and the transitions between them, then modelled them into a state transition diagram to keep track of which stage the player is currently in. However, since we were only asked to create a prototype of the game, we did not implement most of the states we came up with, but instead focused on implementing the core gameplay mechansims and included only a few states (navigating in the scene, interacting with a mug, opening a door and opening a wardrobe). Hence, the focus of our project was to create a game as immersive as possible, so that the user would feel like they are actually inside a real escape room - to which we succeeded. We achieved this by using realistic assets (furniture, wallpaper, etc.), sound effects, scaling the room environment as close to real life as possible, as well as creating smooth interactions and navigation. The GIFs below previews some of the gameplay we recorded of our final prototype, as well as the reactions of other classmates that tested it.

<p align="center">
  <img src="https://github.com/valerija-h/ICS3211-Assignment/blob/master/Images/Navigating.gif" width="40%" />
  <img src="https://github.com/valerija-h/ICS3211-Assignment/blob/master/Images/Navigating-IRL.gif" width="40%" />
</p>
<p align="center"><b>GIF 1</b> - Navigating around the scene</p>

<p align="center">
  <img src="https://github.com/valerija-h/ICS3211-Assignment/blob/master/Images/Mug-P1.gif" width="30%" />
  <img src="https://github.com/valerija-h/ICS3211-Assignment/blob/master/Images/Mug-IRL.gif" width="30%" />
  <img src="https://github.com/valerija-h/ICS3211-Assignment/blob/master/Images/Mug-P2.gif" width="30%" />
</p>
<p align="center"><b>GIF 2</b> - Interacting with objects</p>

<p align="center">
  <img src="https://github.com/valerija-h/ICS3211-Assignment/blob/master/Images/Decisions.gif" width="60%" />
</p>
<p align="center"><b>GIF 3</b> - Interacting with UI</p>
