# HoloLens_App
Making simple HoloLens 2 application and object recognition using Vuforia.

Setting MRTK to Unity

1. Install Visual Studio 2022

2. Setting Visual Studio Installer
- Install .Net 데스크톱 개발
- Install 유니버셜 Windows 플랫폼 개발
- C++을 사용한 데스크톱 개발
- Unity를 사용한 게임 개발

3. Add modual in Unity Hub
- Universal Windows Platform Build Support

4. Turn on the development mode in Hololens2
- 설정 > 업데이트 및 보안 > 개발자용
- 장치 검색: 켬
- 장치 포털: 켬

5. Download MRTK tool
- https://www.microsoft.com/en-us/download/confirmation.aspx?id=102778

6. Start MRTK tool
- Select project (your Unity project). In you want to commit github, you could set on github before setting MRTK.
- Discover features
  - Mixed Reality Toolkit > Mixed Reality Toolkit Extensions
  - Platform Support > Mixed Reality OpenXR Plugin
  
7. Switch Platform in Unity
- Universal Windows Platform
- Architecture
  - ARM64

8. MRTK Project Configurator
- Unity OpenXR Plugin (recommeneded)

9. Project Settings
- XR Plug-in Management > OpenXR
- Click warning icon and fix all
- Depth Submission Mode
  - Depth 16 Bit
- Add Interaction Profiles
  - Eye Gaze interaction Profile
  - Microsoft Hand Interaction Profile
  - Microsoft Motion Control Profile
- OpenXR Feature Groups
  - Hand Tracking
  - Motion Controller Model
- Plug-in Provider
  - OpenXR
  - Microsoft HoloLens feature group
  
10. Click menu
- Mixed Reality > Add to Scene and Configure

11. Press Play button
- If you press the spacebar, you can see hand object on your Game scene.
