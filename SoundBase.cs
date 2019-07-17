using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PetFamily
{
    public class SoundBase : MonoBehaviour
    {
        public void PlaySound(int soundID)
        {
            SoundMgr.Singleton.Play2DSound(soundID);
        }
    }
}
