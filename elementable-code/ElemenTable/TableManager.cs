using System;
using System.Collections.Generic;
using System.Drawing;
using Bluegrams.Periodica.Data;

namespace ElemenTable
{
    public class TableManager
    {
        public PeriodicTable PeriodicTable { get; private set; }
        public Dictionary<string, Color> CurrentColor { get; private set; }
        public Dictionary<string, Color> GroupColor { get; private set; }
        public Dictionary<string, Color> StateColor { get; private set; }
        public Dictionary<string, Color> TypeColor { get; private set; }

        public TableManager()
        {
            PeriodicTable = PeriodicTable.Load(System.Globalization.CultureInfo.CurrentUICulture);
            GroupColor = new Dictionary<string, Color>()
            {
                {ElementCategory.AlkaliMetal.ToString(), Color.LightGreen},
                {ElementCategory.AlkalineEarthMetal.ToString(), Color.LightSeaGreen},
                {ElementCategory.NobleGas.ToString(), Color.Khaki},
                {ElementCategory.Halogen.ToString(), Color.Orange},
                {ElementCategory.Nonmetal.ToString(), Color.OrangeRed},
                {ElementCategory.Metalloid.ToString(), Color.MediumOrchid},
                {ElementCategory.PostTransitionMetal.ToString(), Color.Violet},
                {ElementCategory.TransitionMetal.ToString(), Color.CornflowerBlue},
                {ElementCategory.Lanthanoid.ToString(), Color.LightSkyBlue},
                {ElementCategory.Actinoid.ToString(), Color.LightBlue},
            };
            StateColor = new Dictionary<string, Color>()
            {
                {"Solid", Color.FromArgb(160,160,160)},
                {"Liquid", Color.DodgerBlue },
                {"Gas", Color.YellowGreen }
            };
            TypeColor = new Dictionary<string, Color>()
            {
                {"Stable", Color.PaleGreen },
                {"Radioactive", Color.Yellow },
                {"Synthetic", Color.PaleVioletRed }
            };
            CurrentColor = GroupColor;
        }

        public void SetColorDesign(int number)
        {
            if (number == 2)
                CurrentColor = TypeColor;
            else if (number == 1)
                CurrentColor = StateColor;
            else
                CurrentColor = GroupColor;
        }

        public Color GetCurrentColor(Element elem)
        {
            if (CurrentColor == StateColor)
                return StateColor[elem.StandardState.ToString()];
            else if (CurrentColor == TypeColor)
            {
                // Periodica.Data doesn't have this property, so determine its value.
                var type = elem.AbundanceCrust == 0 ? "Synthetic" : elem.Radioactive ? "Radioactive" : "Stable";
                return TypeColor[type];
            }
            else
                return GroupColor[elem.Category.ToString()];
        }
    }
}
