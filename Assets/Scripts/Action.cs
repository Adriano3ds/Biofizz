using UnityEngine;

namespace Biofizz
{
    public interface Action
    {
        void ExecuteAction();
        void ExecuteAction(Player player);

        void ExecuteAction(GameObject gameObject);
    }
}