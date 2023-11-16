using System;

namespace lab10
{
    internal interface InterfaceFigure
    {
        int MoveHorizontally();
        int MoveVertically();
        bool CheckVisibility();
        string ChangeColor();
        double CalculateTheArea();
        void PrintFields();
    }
}