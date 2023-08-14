# UIOptionSelector
A UI prefab that lets you pick between options by clicking on the arrows. Scroll down to see usage.

![image](https://github.com/Klausbdl/UIOptionsSelector/assets/43257834/aadcc812-1d7c-4eb7-a16a-f2995c1f6a0d)


It uses Text Mesh Pro text, but you can easily change the code to accept the normal Text component.
For the visual indicator below, it uses a Horizontal Layout Group. The bars are automatically instanced and uses the property 

# Usage
1) Place the UIOptionSelector in your canvas
2) Input your options on the string list "Options" in the inspector
3) Add an event referencing your "settings" script, it returns an int value, just like a Dropdown
4) In the scene, inside the prefab, you can change the text's properties (font, color, size etc), and even rearange the everything to fit your game. As long as the references in the script aren't lost
5) In the Visual List variables, you can edit the material of the list's images and its colors (they are just images without sprites to appear solid). You can leave the "Mat" variable empty.

Example:

![image](https://github.com/Klausbdl/UIOptionsSelector/assets/43257834/e4c056f2-42cf-45a8-9092-be0f5373bb77)

![ui options selector](https://github.com/Klausbdl/UIOptionsSelector/assets/43257834/4739811e-e279-48e3-a1b1-61280b9b74c5)

