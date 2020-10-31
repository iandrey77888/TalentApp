using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TalentClub.Pages;
using Xamarin.Forms;

namespace TalentClub
{
    public class NewsItem
    {
        #region Members
        private string newsName;
        private string newsText;
        private DateTime date;
        private Kind newsKind;
        private Spec newsSpec;
        #endregion
        #region Properties
        public string NewsName
        {
            get => newsName;
            set
            {
                if (value == null)
                    return;
                newsName = value;
            }
        }
        public string NewsText
        {
            get => newsText;
            set
            {
                if (value == null)
                    return;
                newsText = value;
            }
        }
        public DateTime Date
        {
            get => date;
            set
            {
                if (value == null)
                    return;
                date = value;
            }
        }
        public Kind NewsKind
        {
            get => newsKind;
            set => newsKind = value;
        }
        public Spec NewsSpec
        {
            get => newsSpec;
            set => newsSpec = value;
        }
        #endregion
        public NewsItem(string name, string text, DateTime date, Kind kind, Spec spec)
        {
            NewsName = name;
            NewsText = text;
            Date = date;
            NewsKind = kind;
            newsSpec = spec;
        }
    }
}
