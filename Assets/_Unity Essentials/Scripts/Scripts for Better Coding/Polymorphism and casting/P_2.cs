public class Mammal1
{
    public void GrowFur()
    { }
}
public class Cat1 : Mammal1
{
    public void Meow()
    { }
}
public class Dog1 : Mammal1
{
    public void Woof()
    { }
}
public class RescueShelter
{
    public Mammal1[] mammals;
    public RescueShelter()
    {
        mammals = new Mammal1[2];
        mammals[0] = new Cat1();
        mammals[1] = new Dog1();
    }
}