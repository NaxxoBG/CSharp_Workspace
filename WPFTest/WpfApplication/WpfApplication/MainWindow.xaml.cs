using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // MainWindowa koito se pokazva pri startirane na programata.
        public MainWindow()
        {
            // Set-vame title-a na prozoreca
            Title = "Media library";
            
         // Tuk syzdavame list s primerni Multimedia obekti koito gi vijdash v ListBox-a kato startirash programata.            
            var ls = new List<Multimedia>
            {
                new Multimedia("Iron man", "Jon Favreau", "Action, Adventure, Sci-Fi", Multimedia.MediaType.DVD),
                new Multimedia("Thor: Ragnarok", "Taika Waititi", "Action, Adventure, Comedy", Multimedia.MediaType.DVD),
                new Multimedia("The Miracle", "Queen", "Rock, Hard rock, Pop rock", Multimedia.MediaType.CD),
                new Multimedia("Back in Black", "AC/DC", "Heavy metal, hard rock", Multimedia.MediaType.CD)
            };

            InitializeComponent();

            // Tuk addvam vseki element ot lista syzdaden gore, v ListBox-a
            ls.ForEach(e => mediaList.Items.Add(e));

            // Tuk prosto kazvam kato startirash programata, prozorecyt da e v sredata.
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        // Listener za butona koito triggerva poqvata na modal dialoga.
        private void NewItemButton_Click(object sender, RoutedEventArgs e)
        {
            // syzdavam si new instance na modal dialoga i izvikvam ShowDialog, za da se pokaje.
            var newMedia = new ModalDialogNewMedia();
            
            // ShowDialog e blokirasht call. Edva sled kato modal dialoga se zatvori, se prodyljava kym if-a dolu.
            newMedia.ShowDialog();
            
            // Tuk kazvame: Ako statichnoto NewMedia e null, znachi user-a ne e napisal dannite za novoto Multimedia entry ili e cyknal
            // 'X' butona na modal dialoga. Tva oznachava che nqma kakvo da se addva vyv ListBox-a. Ako ne e null, go addvame v Items na ListBox-a.
            if (ModalDialogNewMedia.NewMedia != null)
            {
                mediaList.Items.Add(ModalDialogNewMedia.NewMedia);
            }

            // Set-vame go na null, za da izbegnem add-vane na syshtiq element.
            ModalDialogNewMedia.NewMedia = null;
        }

        // Tva e listener, koito se executva kato selectvash element ot ListBox-a.
        private void MediaList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Izbqgvame greshki ako v spisyka se e vmyknal element, koito ne e Multimedia.
            if (!(mediaList.SelectedItem is Multimedia media)) return;
            
            // Tuk smenqme teksta na TextBlock-ovete sprqmo elementa, koito sme selectnali
            TxtBlockTitle.Text = media.Title;
            TxtBlockArtist.Text = media.Artist;
            TxtBlockGenre.Text = media.Genre;
            TxtBlockType.Text = media.Type.ToString();
        }
    }
}
