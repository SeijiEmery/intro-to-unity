# intro-to-unity

Basic intro to unity project demo-ed at the 1st GDA programming meeting for fall 2019.

To download this project w/ git commandline, run `git clone https://github.com/SeijiEmery/intro-to-unity.git; cd intro-to-unity` in a *nix terminal

Or to download w/ github desktop, go to File > Clone Repository and paste this URL: `https://github.com/SeijiEmery/intro-to-unity.git`

You can look at the project as of individual commits by running `git checkout <commit-id>`, eg. `git checkout 0fb8f627b2da83cfd2c25ec5aaf5876cac6c7b4a`. 

What we covered in this meeting was:

- Took a look at a past GDA project: [https://github.com/occultus-ocularus/Occultus-Ocularus](https://github.com/occultus-ocularus/Occultus-Ocularus)
- Went through the unity editor interface and edit handles in the scene view (mapped to keys Q-T)
– Went over player input
– Explained transforms + Vector3
– Explained importance of applying `Time.deltaTime`, ie. `transform.Translate(moveDir * moveSpeed * Time.deltaTime)`, where `var moveDir = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"))` and `public float moveSpeed = 10.0f // units: m/s`
- Used transform.LookAt() + Vector3.Lerp() to build a simple 3d camera (and explained the math behind the camera offset used in `Camera.cs`)
