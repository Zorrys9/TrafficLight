namespace Logic
{
    public class TrafficLightColor
    {
        public static bool red = true;
        public enum EnumColor
        {
            Red,
            Yellow,
            Green
        }
        public static EnumColor CurrentColor;

        public static void Change(object sender, object e)
        {
            switch (CurrentColor)
            {
                case EnumColor.Yellow:
                    if (!red)
                    {
                        CurrentColor = EnumColor.Red;
                    }
                    else if (red)
                    {
                        CurrentColor = EnumColor.Green;
                    }

                    break;
                case EnumColor.Red:
                    CurrentColor = EnumColor.Yellow;
                    red = true;
                    break;
                case EnumColor.Green:
                    CurrentColor = EnumColor.Yellow;
                    red = false;
                    break;
                default:
                    CurrentColor = EnumColor.Red;
                    break;
            }

        }


    }
}
