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
    public partial class NewsPage : ContentPage
    {
        public ObservableCollection<NewsItem> Items { get; set; }
        public string[] filters = { "Всё", "Олимпиады", "Акции", "Поездки" };

        public NewsPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<NewsItem>();
            Items.Add(new NewsItem("Цифровой прорыв", "Как молодому стартапу попасть в акселератор. Типичные ошибки стартапов при подаче в акселератор. Какие ошибки надо учесть при презентации стартапа инвестору ? Какие ошибки совершают стартаперы в коммуникации с потенциальным инвестором / корпорацией ? Смотри интервью Чингиза Сабиева, главного аналитика отдела инноваций Газпромбанка :desktop: 31 октября в 13:00 по МСК / 15:00 по ЕКБ.", DateTime.Now, Kind.News, Spec.Art));
            Items.Add(new NewsItem("Не иначе как колдовство...", "Не иначе как колдовство помогло нам сделать этот день таким продуктивным. Смотрите сами:\n\n4.3Тб трафика общения в DISCORD\n1.4к коммитов кода\n9.2к оценок выставлено командам\n30 часов без сна", DateTime.Now, Kind.News, Spec.Science));

            Filter.ItemsSource = filters;
            Filter.SelectedIndex = 0;
            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert(((NewsItem)e.Item).NewsName, ((NewsItem)e.Item).NewsText + "\n\n"
                + "Теги: #" + ((NewsItem)e.Item).NewsSpec + "\n\n"
                + ((NewsItem)e.Item).Date.ToShortDateString(), "Закрыть");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
