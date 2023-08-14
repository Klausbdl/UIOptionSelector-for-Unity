# UIOptionSelector
A UI prefab that lets you pick between options by clicking on the arrows. Scroll down to see usage.
![image](https://github.com/Klausbdl/UIOptionSelector/assets/43257834/1cb7a60a-d937-49a6-afe5-6e27708c1c92)
It uses Text Mesh Pro text, but you can easly change the code to accept the normal Text component.
For the visual indicator below, it uses a Horizontal Layout Group.


### Credits
Arrows sprites by <a href="https://assetstore.unity.com/packages/2d/gui/icons/simple-ui-elements-53276">Simple UI Elements</a> on the Unity Asset Store

# Usage
1) Input your options on the string list "Options"
2) Add an event referencing your "settings" script, it returns an int value, just like a Dropdown
3) In the scene, inside the prefab, you can change the text's properties (font, color, size etc), and even rearange the everything to fit your game. As long as the references in the script aren't lost.
4) In the Visual List variables, you can edit the material of the list's images and its colors (they are just images without sprites to appear solid)

Example:
![image](https://github.com/Klausbdl/UIOptionSelector/assets/43257834/6658803d-e630-4b29-8430-acf03055a755)
