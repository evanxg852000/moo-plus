using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;


namespace Yalamo.Gui
{
    public delegate void BorderChangedHandler();

    [TypeConverter(typeof(BorderConverter))]
    public class Border
    {
        public event BorderChangedHandler BorderChanged ;
        
        private int left;
        private int right;
        private int top;
        private int bottom;

        public int Left
        {
            get { return this.left; }
            set { this.left = value;this.RaiseEvent();}
        }
        public int Top
        {
            get { return this.top; }
            set { this.top = value; this.RaiseEvent(); }
        }
        public int Right
        {
            get { return this.right; }
            set { this.right = value; this.RaiseEvent(); }
        }
        public int Bottom
        {
            get { return this.bottom; }
            set { this.bottom = value; this.RaiseEvent(); }
        }

        public Border()
        {
            this.left = 0;
            this.top = 0;
            this.right = 0;
            this.bottom = 0;
        }
        public Border(int left, int right, int top, int bottom)
        {
            this.left = left;
            this.right = right;
            this.top = top;
            this.bottom = bottom;
        }
        public override string ToString()
        {
            return this.left + ", " + this.right + ", " + this.top + ", " + this.bottom;
        }
        private void RaiseEvent(){
            if(BorderChanged != null){
                this.BorderChanged();
            } 
        }

    }

    public class BorderConverter : TypeConverter
    {
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(value);

        }
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            Border border = new Border();
            if (value.GetType() == typeof(String))
            {
                string[] array = (value as String).Split(',');
                border.Left = int.Parse(array[0]);
                border.Right = int.Parse(array[1]);
                border.Top = int.Parse(array[2]);
                border.Bottom = int.Parse(array[3]);
            }
            return border;
        }
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType.Equals(typeof(String)))
            {
                return true;
            }
            else
            {
                return base.CanConvertFrom(context, sourceType);
            }
        }
    }


}
