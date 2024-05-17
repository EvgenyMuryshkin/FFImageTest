using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFImageTest.Client.Lib.Controls.ListView
{
    public partial class DetailsTemplate : BaseDetailsRowViewCell
    {
        private string _ImageSrc = "";
        private Color _CategoryColor = Colors.Transparent, _BackgroundColor = Colors.White, _TextColor = Colors.Black;
        private string _Text = "", _Description = "";

        //public virtual int SortOrder => 0;

        public DetailsTemplate()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty CategoryColorProperty = BindableProperty.Create(nameof(CategoryColor), typeof(Color), typeof(DetailsTemplate));
        public Color CategoryColor
        {
            get => _CategoryColor;
            set
            {
                _CategoryColor = value;
                SetValue(CategoryColorProperty, _CategoryColor);
            }
        }

        public static readonly BindableProperty ImageSrcProperty = BindableProperty.Create(nameof(ImageSrc), typeof(string), typeof(DetailsTemplate));
        public string ImageSrc
        {
            get => _ImageSrc;
            set
            {
                _ImageSrc = value;
                SetValue(ImageSrcProperty, _ImageSrc);
            }
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(DetailsTemplate));
        public string Text
        {
            get => _Text;
            set
            {
                _Text = value;
                SetValue(TextProperty, _Text);
            }
        }

        public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(nameof(Description), typeof(string), typeof(DetailsTemplate));
        public string Description
        {
            get => _Description;
            set
            {
                _Description = value;
                SetValue(DescriptionProperty, _Description);
            }
        }

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(DetailsTemplate));
        public Color TextColor
        {
            get => _TextColor;
            set
            {
                _TextColor = value;
                SetValue(TextColorProperty, _TextColor);
            }
        }
    }

}