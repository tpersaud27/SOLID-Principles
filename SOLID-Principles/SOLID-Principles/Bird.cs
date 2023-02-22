namespace SOLID_Principles
{
    /*
     * This demonstrated the implementation where Liskov Substitution Principle is broken
    public class Bird
    {
        public void Fly()
        {
        }
    }

    /// <summary>
    /// We can see here that this does not follow Liskov Substitution Principle
    /// If we substitute the subclass (Ostritch) with the base class (Bird). It does not work because an Ostritch does not fly
    /// This implementation is where the Liskov Substitution Principle is broken
    /// </summary>
    public class Ostrich: Bird
    {

    }
    */

    /**
     * We can see in the implementation below that if we substitute any of the subclasses with the base class the implementation still stands
     * Pigeon can be substituted with FlyingBird
     * Ostritch can be substitued with Bird
    */
    public class Bird
    {

    }
    public class FlyingBird : Bird
    {
        public void Fly() { }
    }

    public class Ostrictch: Bird
    {

    }
    public class Pigeon: FlyingBird
    {

    }


}
