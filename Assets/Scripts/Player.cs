using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Biofizz
{
    public class Player
    {
        private string _id;
        private string _name;
        private float _score = 0;
        private Transform _transform;
        private Material _material;
        private bool _triggered, _ended=false;
        public Player(string name)
        {
            _name = name;
            _score = 0;
            _id = GetUniqueID();
        }

        public Player(string name, Transform transform)
        {
            _name = name;
            _score = 0;
            _transform = transform;
            _id = GetUniqueID();
        }

        public Player(string name, Material material)
        {
            _name = name;
            _score = 0;
            _material = material;
            _id = GetUniqueID();
        }

        public string Id
        {
            get => _id;
        }

        public string Name
        {
            get => _name;
        }

        public float Score
        {
            get => _score;
        }

        public Material Material
        {
            get => _material;
        }

        public bool Triggered
        {
            get => _triggered;
        }

        public bool Done
        {
            get => _ended;
        }

        public void Trigger()
        {
            _triggered = true;
        }

        public void Untrigger()
        {
            _triggered = false;
        }

        public void Finish()
        {
            _ended = true;
        }

        public void AddScore(float value)
        {
            _score += value;
        }

        public Transform Transform
        {
            get => _transform;
        }

        public void Focus()
        {
            Vector3 cpos = GameModeManager.camera.transform.position;
            Vector3 pos = Transform.position + new Vector3(0, 1.15f);
            if(pos.y > 0.6f)
            {
                cpos.y = 0.6f;
                GameModeManager.camera.transform.position = cpos;
            }
            else
            {
                cpos.y = pos.y;
                GameModeManager.camera.transform.position = cpos;
            }
        }

        public void SetTransform(Transform transform)
        {
            _transform = transform;
        }

        private string GetUniqueID()
        {
            var random = new System.Random();
            DateTime epochStart = new System.DateTime(1970, 1, 1, 8, 0, 0, System.DateTimeKind.Utc);
            double timestamp = (System.DateTime.UtcNow - epochStart).TotalSeconds;

            string uniqueID = Application.systemLanguage                            //Language
                    + "-" + Application.platform.ToString()                                            //Device    
                    + "-" + String.Format("{0:X}", Convert.ToInt32(timestamp))                //Time
                    + "-" + String.Format("{0:X}", Convert.ToInt32(Time.time * 1000000))        //Time in game
                    + "-" + String.Format("{0:X}", random.Next(1000000000))                //random number
                    + "-" + _name;

            return uniqueID;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType() || obj == null) return false;
            return Id == ((Player)obj).Id;
        }

        public override int GetHashCode()
        {
            var hashCode = 798231423;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_name);
            hashCode = hashCode * -1521134295 + _score.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Score.GetHashCode();
            return hashCode;
        }
    }
}