using System.CodeDom;

internal class PotatoeProperCooker
{
    Potato potato;
    //... 
    if (potato != null)
    {
        if ((potato.HasNotBeenPeeled = false) && (potato.IsRotten = true))
        {
            Cook(potato);
        }
        else
        {
            //throw severe recepie violation error!
        }
    }
    else
    {
        //throw potato... uh I mean Error! 
    }
}
