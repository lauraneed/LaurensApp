using LaurensApp1.Models;
using System.Collections.ObjectModel;
using System.Net;

namespace LaurensApp1.Pages;

public partial class ChatsPage : ContentPage
{
	public ChatsPage()
	{
        InitializeComponent();

        Chats = new ObservableCollection<ChatsModel>(LoadChats());

		BindingContext = this;
	}

    public ObservableCollection<ChatsModel> Chats { get; set; }
	private static IEnumerable <ChatsModel> LoadChats()
	{
		return new List<ChatsModel>
		{
		 new ChatsModel(("profilepic3.jpg"),"Max", DateTime.Now.AddDays(-2) ,0),
		 new ChatsModel(("profilepic1.jpg"),"Hailey",DateTime.Now.AddHours(-2),2),
		 new ChatsModel(("profilepic2.jpg"),"Stan",DateTime.Now.AddDays(-2),0),
		 new ChatsModel(("profilepic4.jpeg"),"Roger",DateTime.Now.AddDays(-2),0),
		};
	}

}
