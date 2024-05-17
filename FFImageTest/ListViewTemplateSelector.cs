using FFImageTest.Client.Lib.Controls.ListView;

namespace FFImageTest
{
    public class ListViewTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DetailsTemplate { get; set; }
        public DataTemplate DetailsActionTemplate { get; set; }
        public DataTemplate CustomTemplate { get; set; }

        public ListViewTemplateSelector()
        {
            DetailsTemplate = new DataTemplate(typeof(DetailsTemplate));
            DetailsActionTemplate = new DataTemplate(typeof(DetailsActionTemplate));
            CustomTemplate = new DataTemplate(typeof(CustomTemplate));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var Item = item as DetailsInfo;

            if (Item.IsCustom)
            {
                return CustomTemplate;
            }

            if (Item.Action != null)
            {
                return DetailsActionTemplate;
            }

            return DetailsTemplate;
        }
    }

    public abstract class DetailsInfo : BindableObject
    {
        public abstract View DisplayItem { get; }

        public virtual bool IsCustom => false;

        private Action _Action;
        public Action Action
        {
            get { return _Action; }
            set
            {
                _Action = value;
                OnPropertyChanged();
            }
        }

        private string _GroupName = "Summary";
        public string GroupName
        {
            get { return _GroupName; }
            set
            {
                _GroupName = value;
                OnPropertyChanged();
            }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }
    }

    public class TextDetailsInfo : DetailsInfo
    {
        private string _Description;
        public virtual string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                OnPropertyChanged("Description");
            }
        }

        public override View DisplayItem => new Label() { Text = (Description ?? "").Trim() };
    }

    public class ViewDetailsInfo : DetailsInfo
    {
        public View View { get; set; }

        public override View DisplayItem => View;
    }

    public class CustomDetailsInfo : ViewDetailsInfo
    {
        public override bool IsCustom => true;
    }
}
