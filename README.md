# VRGame_sloos

---
## Requirements

Create a room in VR based on the Inctober List from 2019.

    - Move inside the Room
    - Grab and Move Objects
    - Solve a Mystery
    - Have sounds inside the Game
    - animated Globe (spin and rotate)
---   
### Data:

Development Platforms: Mac Os Mojave Version 10.14.6 / Unity Version 2019.1.14f1 / XCode
Target Platform: iOs version 12.4.2

### Concept/Idea:

Inktober prompt list: Dark, Dragon

I will create a dark VR room. In this room you can move freely. There will be laying random objects all over the place. In the middle of the room there are 3 poles. Behind the poles you can see a picture of a dragon wearing a crown, a neckless and a ring. This 3 objects you have to find in the room. After you find the objects you have to grab them and lay them onto each pole. If it's the correct object it will make a sound. The whole room will look asian and have a background music. Next to the dragon picture there will also be two globes that turn and are rotated.

---   
### Errors/Fails:

### iOS:

Error #1:
Failed to build

Result #1:
At first I tried to install "UnitySetup-iOS-Support-for-editor-2019.1.14f1.pkg" because I thought that this was missing. Then it failed to install. I searched for an answer why it failed to instal. After a long time I realized that I already had intalled this package. So what was missing? I had to install XCode for my Mac. After installing XCode, unity said "build sucessful" which brings us to my next Error.

![alt text](https://github.com/sloos123/VRGame_sloos/img/Error1.png)

Error #2:
While in Unity it said "build successful" in XCode the build failed.
It had an eeror in the provisioning profile.
After looking it up on the website "https://headjack.io/tutorial/distribute-google-cardboard-app-ios-outside-app-store/" I saw that bulding this on an IPhone is way more work then on an Android, so I switched the device and startet from "new".

Result #2:
Change Platform because of unnecessary time and work issues.

### Android:

Error #1:
The first Error turned the whole game on the phone upside down and every movement was the opposite of the actual movement. 

Result #1:
In Project settings > Player Settings > Other settings > Rendering > Graphic API's i had to remove "Vulkan"