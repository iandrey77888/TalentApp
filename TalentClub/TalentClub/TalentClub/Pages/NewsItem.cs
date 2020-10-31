using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TalentClub.Pages
{
    public class NewsItem
    {
        #region Members
        private Image image;
        private string text;
        private DateTime dateTime;
        #endregion
        #region Properties
        public Image NewsImage
        {
            get => image;
            private set
            {
                if (value == null)
                    return;
                image = value;
            }
        }
        public string NewsText
        {
            get => text;
            private set
            {
                if (value == null)
                    return;
                text = value;
            }
        }
        public string PublishedTimeString => dateTime.ToShortDateString();
        public DateTime PublishedTime
        {
            get => dateTime;
            private set
            {
                dateTime = value;
            }
        }
        #endregion
        #region Constructors
        public NewsItem(Image image, string text)
        {
            NewsImage = image;
            NewsText = text;
            PublishedTime = DateTime.Now;
        }
        public NewsItem(string image_path, string text)
        {
            NewsImage = new Image() { Source = image_path };
            NewsText = text;
            PublishedTime = DateTime.Now;
        }
        #endregion
    }
}
