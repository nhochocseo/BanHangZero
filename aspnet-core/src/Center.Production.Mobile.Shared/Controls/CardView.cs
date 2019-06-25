using Xamarin.Forms;

namespace Center.Production.Controls
{
    public class CardView : Frame
    {
        public CardView()
        {
            Padding = 0;

            if (Device.RuntimeCenter == Device.iOS)
            {
                HasShadow = false;
                OutlineColor = Color.Gray;
            }
        }
    }
}

