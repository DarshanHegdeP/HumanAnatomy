# ​​​HumanAnatomy — Unity + Vuforia AR Project

**Repository URL**: [https://github.com/DarshanHegdeP/HumanAnatomy](https://github.com/DarshanHegdeP/HumanAnatomy)

---

##  Overview  
This Unity-based project leverages the **Vuforia Engine** to create an immersive **Augmented Reality (AR)** experience for learning human anatomy. Users can visualize and interact with 3D anatomical models by scanning image targets.

---

##  Features
- Augmented Reality visualization with **Vuforia Image Targets**
- Interactive 3D human anatomy models (rotate, zoom, grab)
- Modular architecture for adding more anatomical systems
- Unity-compatible build for platforms like Android, iOS, and Windows

---

##  Repository Structure
```
HumanAnatomy/
├── Assets/ # Unity project assets and scenes
├── Packages/ # Unity packages including Vuforia (.tgz)
├── ProjectSettings/ # Unity project settings
├── QCAR/ # (Possibly Vuforia config, auto-generated)
├── .gitattributes # Git LFS configuration
├── .gitignore # Unity-specific exclusions
└── README.md # Documentation (this file)
```

---

##  Prerequisites
- **Unity** (2021.3 LTS or later recommended)
- **Vuforia Engine** (e.g., `com.ptc.vuforia.engine-*.tgz`)
- **Git LFS** for large assets

---

##  Getting Started

```bash
git clone https://github.com/DarshanHegdeP/HumanAnatomy.git
cd HumanAnatomy
git lfs install
git lfs pull
```
Then, open the project using Unity Hub — choose the folder and let Unity import assets.

## Setting Up Vuforia in Unity
- Open Window → Package Manager in Unity.
- Import the Vuforia package if not present (likely under Packages/).
- In Player Settings → XR → Enable Vuforia Augmented Reality Supported.
- Configure the Vuforia License Key via Window → Vuforia Configuration.

## Building for Mobile
Platform	Steps
- Android	File → Build Settings → Android → set up Vuforia support → Build APK
- iOS	File → Build Settings → iOS → export to Xcode → build via Xcode

## How It Works
- Uses Image Targets to detect real-world markers.
- Positions corresponding 3D anatomy models in AR.
- Uses Unity scripts for interactivity—zooming, rotating, grabbing.
