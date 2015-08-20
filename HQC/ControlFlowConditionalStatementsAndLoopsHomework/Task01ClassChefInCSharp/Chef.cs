using System;
public class Chef
{
    private Bowl GetBowl()
    {
        //... 
    }
    private Potato GetPotato()
    {
        //...
    }
    private Carrot GetCarrot()
    {
        //...
    }
    private void Cut(Vegetable anyVegetable)
    {
        //...
    }
    public void Cook()
    {
        Bowl bowl = GetBowl();

        Potato potato = GetPotato();
        Peel(potato);
        Cut(potato);
        bowl.Add(potato);

        Carrot carrot = GetCarrot();
        Peel(carrot);
        Cut(carrot);
        bowl.Add(carrot);

    }
}