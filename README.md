# intro-to-unity

Basic intro to unity project demo-ed at the 1st GDA programming meeting for fall 2019.

To download this project w/ git commandline, run `git clone https://github.com/SeijiEmery/intro-to-unity.git; cd intro-to-unity` in a *nix terminal

Or to download w/ github desktop, go to File > Clone Repository and paste this URL: `https://github.com/SeijiEmery/intro-to-unity.git`

You can look at the project as of individual commits by running `git checkout <commit-id>`, eg. `git checkout 0fb8f627b2da83cfd2c25ec5aaf5876cac6c7b4a`. 

What we covered in this meeting was:

- Took a look at a past GDA project: [https://github.com/occultus-ocularus/Occultus-Ocularus](https://github.com/occultus-ocularus/Occultus-Ocularus)
- Went through the unity editor interface and edit handles in the scene view (mapped to keys Q-T)
- Went over player input:
  - `Input.GetButton(<axis-name>)`
  - `Input.GetButtonDown(<axis name>)`
  - `Input.GetAxis(<axis-name>)`
- Explained transforms + Vector3
- Explained importance of applying `Time.deltaTime` in `Movement.cs`
  - `transform.Translate(moveDir * moveSpeed * Time.deltaTime)`, where 
    - `var moveDir = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"))`
    - `public float moveSpeed = 10.0f // units: m/s`
  - importance of physics + physics units (physics units are just a type system! :))
    - movement is `m/s`
    - translation is `m`
    - input is unitless
    - therefore `movement = moveDir * moveSpeed` => `m/s` != `m` indicates that we have a conceptual error
    - namely that we specificed move speed in `m/s` but what we're *actually* doing is moving the player `10m` every *frame*, ie `10m/s * framerate` => `600 m/s` (but framerate dependent, so unpredictable!)
    - to fix this we multiply by Time.deltaTime (units: `s`) and now all our math checks out, and the player does in fact move at `10m/s` :)
- Used `transform.LookAt()` + `Vector3.Lerp()` to build a simple 3d camera 
  - explained quaternions
    - applies rotations :)
  - `transform.rotation * Vector3.back` => unit-length Vector3 facing behind the player's current rotation 
  - `transform.rotation * Vector3.back * 10 + Vector3.up * 5` => position 10m behind, 5m above player's rotation
- prefabs
- scenes
- components + monobehaviors (did we cover `GetComponent<T>()`?)
  
Topics we did not fully cover:

- [rigidbodies, colliders, and triggers](https://docs.unity3d.com/Manual/PhysicsSection.html)
  - making the player jump by calling `rigidbody.AddForce()`
  - adding a death trigger to kill the player when they fall off
- adding health pickups, damage triggers ("spike traps"), and collectibles
- showing a health bar w/ unity's legacy GUI (`OnGUI`, `GUI.Rect()`, `GUI.Label()`, `GUILayout`, et al)
- player respawn via `GameObject.Instantiate()`
– building a level via prefabs
- having everyone fork this repo, make your own level + gameplay extensions, and merge back by filling out PRs
