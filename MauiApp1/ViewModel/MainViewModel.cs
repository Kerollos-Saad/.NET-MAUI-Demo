
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewModel;

public partial class MainViewModel : ObservableValidator
{
	public MainViewModel()
	{
		Items = new ObservableCollection<string>();
	}

	[ObservableProperty]
	private ObservableCollection<string> items;

	[ObservableProperty] 
	string text;

	[RelayCommand]
	void Add()
	{
		if (string.IsNullOrEmpty(Text))
			return;

		Items.Add(Text);
		// add out item
		Text = string.Empty;
	}

	[RelayCommand]
	void Delete(string s)
	{
		if(Items.Contains(s))
			Items.Remove(s);
	}

	[RelayCommand]
	async Task Tap(string s)
	{
		await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
	}
}

