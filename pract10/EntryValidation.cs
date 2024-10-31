using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract10
{
	public class EntryValidation : TriggerAction<Entry>
	{
		public bool IsValid { get; private set; }

		protected override void Invoke(Entry sender)
		{
			int num;
			IsValid = Int32.TryParse(sender.Text, out num);

			
			if (IsValid)
			{
				sender.TextColor = Colors.Black;
			}
			else {	sender.TextColor = Colors.Red; }
			
			var parent = sender.Parent;
			while (parent != null && !(parent is StackLayout))
			{
				parent = parent.Parent;
			}

			if (parent != null)
			{
				var radioButtons = parent.FindByName<StackLayout>("zxc"); 
				foreach (var child in radioButtons.Children)
				{
					if (child is RadioButton radioButton)
					{
						
						if (IsValid)
						{
							radioButton.TextColor = Colors.Black;
						}
                        else
                        {
							radioButton.TextColor = Colors.Red;
                        }
                        radioButton.IsEnabled = IsValid;
					}
				}
			}
		}



	}
}
