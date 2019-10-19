using Logic.Enums;
using System;
using System.Windows;
using System.Windows.Threading;

namespace Logic
{
    public class TrafficLightColor
    {
        public static EnumColor CurrentColor;
        public static int count = 0;
        public static void Change(object sender, object e)
        {
            if (count <= 10) // Если количество срабатываний метода превысит 10, то начнет мигать желтый цвет
            {
                count++;
                switch (CurrentColor)
                {
                    case EnumColor.Stop:
                        CurrentColor = EnumColor.Ready;
                        break;
                    case EnumColor.Ready:
                        CurrentColor = EnumColor.Go;
                        break;
                    case EnumColor.Go:
                        CurrentColor = EnumColor.Wait;
                        break;
                    case EnumColor.Wait:
                        CurrentColor = EnumColor.Stop;
                        break;
                }
            }
            else
            {
                switch (CurrentColor)
                {
                    case EnumColor.Wait:
                        CurrentColor = EnumColor.None;
                        break;
                    case EnumColor.None:
                        CurrentColor = EnumColor.Wait;
                        break;
                }
                
            }

        }
    }
}
