using UnityEngine;

namespace Class_15_interface
{
    public interface IUseable
    {
        void Use();
    }
    public interface IDestroyable
    {
        void Destroy();
    }
    public class Potion : IUseable, IDestroyable
    {
        private string _name;
        public Potion(string name)
        {
            _name = name;
        }

        public void Destroy()
        {
            Debug.Log($"使用完 {_name}, 刪除.");
        }

        public void Use()
        {
            Debug.Log($"使用 {_name}");
            Destroy();
        }
    }
    public class Equipment : IUseable
    {
        private string _name;
        public Equipment(string name)
        {
            _name = name;
        }
        public void Use()
        {
            Debug.Log($"裝備 {_name}");
        }
    }
    public class Class_15_interface : MonoBehaviour
    {
        void Start()
        {
            var redPotion = new Potion("紅水");
            var bluePotion = new Potion("藍水");
            var helmet = new Equipment("頭盔");
            redPotion.Use();
            bluePotion.Use();
            helmet.Use();
        }
    }
}
