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
using System.Windows.Shapes;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for ModalDialogNewMedia.xaml
    /// </summary>
    
    // Modal dialog chrez koito se addva nov Multimedia element v ListBox-a.
    public partial class ModalDialogNewMedia : Window
    {
        // Statchiniq MultiMedia element sluji kato vryzkata mejdu main windowa i modal dialoga. Tuk setvame poletata na NewMedia,
        // za da moje v MainWindowa da addnem NewMedia v ListBox-a. Tova e kato container za obekta chiito poleta se opredelqt ot tova kakvo
        // e vkaral usera v modalniq dialog.
        public static Multimedia NewMedia;

        public ModalDialogNewMedia()
        {
            InitializeComponent();

            // Set-vame title-a na prozoreca
            Title = "New Media";

            // Set-vame startup location-a na prozoreca da byde v sredata na ekrana
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        // Listener za butona na modalniq dialog
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Proverqvame dali vyv vsqko ot poletata e vkarana nqkakva informaciq
            if (!string.IsNullOrWhiteSpace(NewTitle.Text) && !string.IsNullOrWhiteSpace(NewArtist.Text) && !string.IsNullOrWhiteSpace(NewGenre.Text) && NewMediaType.SelectedIndex != -1)
            {
                // Ako e vkarana, assignvame nov Multimedia object v statichnoto pole, s informaciqta koqto user-a e podal v poletata
                NewMedia = new Multimedia
                {
                    Title = NewTitle.Text,
                    Artist = NewArtist.Text,
                    Genre = NewGenre.Text,
                    Type = (Multimedia.MediaType) NewMediaType.SelectedIndex
                };
            }
            else
            {
                // Ako ne e, kazvame che NewMedia e null, za da ne moje da se addne v ListBox-a.
                NewMedia = null;
            }

            // Zatvarqme modal dialoga
            Close();
        }
    }
}
