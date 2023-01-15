//using System.Collections;
namespace Course.SOLID.After
{
    public interface IInteract
    {    
        void Interact();
    }
    public interface IHeal
    {    
        void Heal(int value);
    }
    public interface IDamage
    {    
        void Damage(int value);
    }
}
