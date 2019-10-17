
using Logic.Enums;

namespace Logic
{
    public class TrafficLightColor
    {
        public static EnumColor CurrentColor;
        public static void Change(object sender, object e)
        {
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


    }
}
