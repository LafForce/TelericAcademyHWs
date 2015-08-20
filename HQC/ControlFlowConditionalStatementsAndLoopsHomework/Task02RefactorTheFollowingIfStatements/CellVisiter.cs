using System;
static class CellVisiter
{
    const dynamic MIN_X = "Very Special Value Of X";
    const dynamic MAX_X = "Other Very Special Value Of X";
    const dynamic MIN_Y = "Very Special Value Of Y";
    const dynamic MAX_Y = "Other Very Special Value Of Y";
    private static void Main()
    {
        var x = "thisParticularValueOfX";
        var y = "thisParticularValueOfY";
        bool cellIsNOTvisited = false;
        bool xIsBetweenMIN_XandMAX_X = false;
        bool yIsBetweenMIN_XandMAX_Y = false;


        if ((MIN_X <= x) && (x <= MAX_X))
        {
            xIsBetweenMIN_XandMAX_X = true;
        }
        if ((MIN_Y <= y) && (MAX_Y >= y))
        {
            xIsBetweenMIN_XandMAX_X = true;
        }

        if (xIsBetweenMIN_XandMAX_X && yIsBetweenMIN_XandMAX_Y && cellIsNOTvisited)
        {
            VisitCell();
        }
    }

    private static void VisitCell()
    {
        throw new NotImplementedException();
    }
}
