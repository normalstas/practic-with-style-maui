namespace pract10
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();

		}
		RadioButton btn = null;
		private void Chek_CheckedChanged(object sender, CheckedChangedEventArgs e)
		{

			if (!Chek.IsChecked)
			{
				znach1.IsReadOnly = true;

				znach2.IsReadOnly = true;

				lb.Text = " ";
				rb1.Content = " ";
				rb2.Content = " ";
				rb3.Content = " ";
				rb4.Content = " ";
				rb5.Content = " ";
				bt.Text = " ";
				bt.IsEnabled = false;
			}
			else
			{
				znach1.IsReadOnly = false;
				znach2.IsReadOnly = false;
				lb.Text = "Выберите способ";
				rb1.Content = "плюс";
				rb2.Content = "минус";
				rb3.Content = "деление";
				rb4.Content = "умножение";
				rb5.Content = "возвести в степень(1-число,2-степень)";
				bt.Text = "Рассчитать";
				bt.IsEnabled = true;

			}
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			double zn1, zn2, result;
			if (string.IsNullOrEmpty(znach1.Text) || !double.TryParse(znach1.Text, out zn1) ||
				string.IsNullOrEmpty(znach2.Text) || !double.TryParse(znach2.Text, out zn2))
			{
				DisplayAlert("Введите корректные значения", "Пожалуйста", "Хорошо");

			}
			else
			{
				switch (btn.Content)
				{
					case "плюс":
						result = zn1 + zn2;
						res.Text = result.ToString();
						break;
					case "минус":
						result = zn1 - zn2;
						res.Text = result.ToString();
						break;
					case "деление":
						result = zn1 / zn2;
						res.Text = result.ToString();
						break;
					case "умножение":
						result = zn1 * zn2;
						res.Text = result.ToString();
						break;
					case "возвести в степень(1-число,2-степень)":
						result = Math.Pow(zn1, zn2);
						res.Text = result.ToString();
						break;
					default:
						res.Text = "Что-то пошло не так";
						break;
				}
			}


		}

		private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
		{
			btn = sender as RadioButton;
		}

		private void znach_TextChanged(object sender, TextChangedEventArgs e)
		{
			res.Text = string.Empty;
		}

		

		
	}

}


