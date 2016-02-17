namespace StudentClass
{
    public class PropertyChangedEventArgs
    {
        public PropertyChangedEventArgs(string propertyName, object oldValue, object newValue)
        {
            this.PropertyName = propertyName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropertyName { get; set; }
        public object OldValue { get; set; }
        public object NewValue { get; set; }
    }
}