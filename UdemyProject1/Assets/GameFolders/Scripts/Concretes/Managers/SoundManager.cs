using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject1.Abstracts.Utilities;

namespace UdemyProject1.Managers
{
    public class SoundManager :SingletonObject<SoundManager>
    {
        AudioSource[] _audioSource;
        private void Awake()
        {
            SingLetonThisGameObject(this);
            _audioSource = GetComponentsInChildren<AudioSource>();
        }
        public void PlaySound(int index)
        {
            if (!_audioSource[index].isPlaying)
            {
                _audioSource[index].Play();
            }
        }
        public void StopSound(int index)
        {
            if (_audioSource[index].isPlaying)
            {
                _audioSource[index].Stop();
            }
        }
    }
}

