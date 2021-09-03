# EasyMainMenuMusic
This simple system will make your main menu have music and you can control it very easily.

# Controls
This system works with a randomly generated number. You will have to adjust some values if you want to add more music. In this demostration, we have **7** songs. So, we will have to adjust this values: `random.Next(1,8);`. This will generate a number between 1 and 7 (The last number is not taken into account and its predecessor). Each song is assinged to a number. Then a random song will be played there. When the first song ends, the game will be checking at each frame if a song is playing right now. If not, it will reproduce a random one. If you press **N** key, it will reproduce another random song.
