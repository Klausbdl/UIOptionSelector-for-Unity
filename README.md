# UIOptionSelector
A UI prefab that lets you pick between options by clicking on the arrows. Scroll down to see usage.

![img 1](img%201.png)

It uses Text Mesh Pro text, but you can easily change the code to accept the normal Text component.
For the visual indicator below, it uses a Horizontal Layout Group. The bars are automatically instanced and uses the property 

# Usage
1) Place the UIOptionSelector in your canvas
2) Input your options on the string list "Options" in the inspector
3) Add an event referencing your "settings" script, it returns an int value, just like a Dropdown
4) In the scene, inside the prefab, you can change the text's properties (font, color, size etc), and even rearange the everything to fit your game. As long as the references in the script aren't lost
5) In the Visual List variables, you can edit the material of the list's images and its colors (they are just images without sprites to appear solid). You can leave the "Mat" variable empty.

Example:

![img 2](img%202.png)

![ui options selector](ui%20options%20selector.gif)

