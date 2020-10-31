using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using TalentClub.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TalentClub
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageDetail : ContentPage
    {
        public ObservableCollection<NewsItem> Items { get; set; }
        public string[] filters = { "Всё", "Олимпиады", "Акции", "Поездки" };

        public MainPageDetail()
        {
            InitializeComponent();

            Items = new ObservableCollection<NewsItem>();
            Items.Add(new NewsItem("QweQweQwe", "AZWazwAZW", DateTime.Now, Kind.News, Spec.Art));
            Items.Add(new NewsItem("Цифровой прорыв", "Как молодому стартапу попасть в акселератор Типичные ошибки стартапов при подаче в акселератор : question:Какие ошибки надо учесть при презентации стартапа инвестору ?: question:Какие ошибки совершают стартаперы в коммуникации с потенциальным инвестором / корпорацией ? :point_right: Смотри интервью Чингиза Сабиева, главного аналитика отдела инноваций Газпромбанка :desktop: 31 октября в 13:00 по МСК / 15:00 по ЕКБ", DateTime.Now, Kind.News, Spec.Art));

            Filter.ItemsSource = filters;
            Filter.SelectedIndex = 0;
            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert(((NewsItem)e.Item).NewsName, ((NewsItem)e.Item).NewsText, "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
