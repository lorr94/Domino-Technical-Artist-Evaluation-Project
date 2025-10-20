# Domino-Technical-Artist-Evaluation-Project

Notes:
* Unity Version: 2021.3.45f2
* Used Google Gemini to create script templates to be later used for define required behaviour
* For proper testing via Play, use in Game window 1080x1920 resolution aspect ratio
* "Animate the colors of the frame (using a shader is recommended )"
  - For this tasks, I used a shader graph for a pulsating effect, instead rainbow-like swirle effects, due to knowledge limitations at the time

Tasks:
Main Window
● Create UI window According to the reference provided
● Create a prefab for the Sticker Placement that supports different number of crowns (1-5)
and a dynamic text for the sticker name Ref image 1 - Sticker placement crowns
● Animate the colors of the frame (using a shader is recommended ) Ref_Seq_01.mp4
● Make sure we can scroll the sticker area (1 and 2 ) horizontally Ref image 2 - Scroll Area
● Create a script that populate sticker area with the Sticker Placement prefab with varied
number of crowns and stickers
● Make sure that all the stickers have a button component which will trigger the
Confirmation Window

Confirmation Window
● Create a confirmation window prefab (Ref Image 3 - Confirmation window)
● When the user clicks on a Sticker Placement we should see an A to B animation (the
sticker of the confirmation screen should start the animation from the position of the
clicked sticker in the Main Window and animate to the center of the screen )
Ref_Seq_02
● When pressing the Red button the window should close
● When pressing the Green button we should see a sequence as seen in the reference
● Use a Timeline to create an animation seq (Ref_Seq_02) of the sticker transformation
● Make sure the sequence is as close as possible to the Reference provided
  - Due to time constraints, only sticker placement animation was created, in addition to the buttons behaviour and conditions.




