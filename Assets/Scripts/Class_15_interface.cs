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
            Debug.Log($"�ϥΧ� {_name}, �R��.");
        }

        public void Use()
        {
            Debug.Log($"�ϥ� {_name}");
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
            Debug.Log($"�˳� {_name}");
        }
    }
    public class Class_15_interface : MonoBehaviour
    {
        void Start()
        {
            var redPotion = new Potion("����");
            var bluePotion = new Potion("�Ť�");
            var helmet = new Equipment("�Y��");
            redPotion.Use();
            bluePotion.Use();
            helmet.Use();
        }
    }
}
