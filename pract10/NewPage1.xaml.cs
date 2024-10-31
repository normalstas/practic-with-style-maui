namespace pract10;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();

	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
		Chek_CheckedChanged(Chek, new CheckedChangedEventArgs(Chek.IsChecked));
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

		}
		else
		{
			znach1.IsReadOnly = false;
			znach2.IsReadOnly = false;
			lb.Text = "�������� ������";
			rb1.Content = "����";
			rb2.Content = "�����";
			rb3.Content = "�������";
			rb4.Content = "���������";
			rb5.Content = "�������� � �������(1-�����,2-�������)";


		}
	}
	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		btn = sender as RadioButton;
		double zn1, zn2, result;
		if (string.IsNullOrEmpty(znach1.Text) || !double.TryParse(znach1.Text, out zn1) ||
			string.IsNullOrEmpty(znach2.Text) || !double.TryParse(znach2.Text, out zn2))
		{
			DisplayAlert("������� ���������� ��������", "����������", "������");

		}
		else
		{
			switch (btn.Content)
			{
				case "����":
					result = zn1 + zn2;
					res1.Text = result.ToString();
					res2.Text = string.Empty;
					res3.Text = string.Empty;
					res4.Text = string.Empty;
					res5.Text = string.Empty;

					break;
				case "�����":
					result = zn1 - zn2;
					res2.Text = result.ToString();
					res1.Text = string.Empty;
					res3.Text = string.Empty;
					res4.Text = string.Empty;
					res5.Text = string.Empty;
					break;
				case "�������":
					result = zn1 / zn2;
					res3.Text = result.ToString();
					res1.Text = string.Empty;
					res2.Text = string.Empty;
					res4.Text = string.Empty;
					res5.Text = string.Empty;
					break;
				case "���������":
					result = zn1 * zn2;
					res4.Text = result.ToString();
					res1.Text = string.Empty;
					res2.Text = string.Empty;
					res3.Text = string.Empty;
					res5.Text = string.Empty;
					break;
				case "�������� � �������(1-�����,2-�������)":
					result = Math.Pow(zn1, zn2);
					res5.Text = result.ToString();
					res2.Text = string.Empty;
					res3.Text = string.Empty;
					res4.Text = string.Empty;
					res1.Text = string.Empty;
					break;
				default:
					DisplayAlert("���-�� ����� �� ���", " ", "������");
					break;
			}
		}
	}

	private void znach_TextChanged(object sender, TextChangedEventArgs e)
	{
		res1.Text = string.Empty;
		res2.Text = string.Empty;
		res3.Text = string.Empty;
		res4.Text = string.Empty;
		res5.Text = string.Empty;
	}
}