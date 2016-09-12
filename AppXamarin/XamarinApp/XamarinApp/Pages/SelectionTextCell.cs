using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace XamarinApp.Pages
{
    public class SelectionTextCell:TextCell
    {
        public SelectionTextCell(string Text,Color color)
        {
            this.TextColor = color;
            this.Text = Text;
        }
    }
}
