using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lista.mvvm
{//tu dzieje sie cała magia musisz zapisać ObservableObject i zrobić tą klase patrialną co to znaczy a sami sprawdzie 
    //nie chce mi sie rozpisywać
    public partial class CheckListViewModel: ObservableObject
    {
        //to tutaj powoduje że obserwowana kolekcja sie wypełnia nie używamy listy bo działa na raz a to sie resetuje
        //sprawdza sie poprostu ssamo
        public CheckListViewModel()
        {
            items = new ObservableCollection<string> { 
                "Zakupy: chleb, masło, ser",
                "Do zrobienia: obiad, umyć podłogi",
                "Weekend: kino, spacer z psem"
            };
        }
        //pliki jak te w dznie takie jak te powinny sie smarzyć w piekle
        //a naserio najedź myszką na [ObservableProperty] bo to ci opisze co robi jak chcesz sie dowiedzieć dokładniej 
        //klikni na to f12
        [ObservableProperty]
        string pisz;

        [ObservableProperty]
        ObservableCollection<string> items;
        //podobnie z tym
        [RelayCommand]
        void add()
        {
            if (string.IsNullOrWhiteSpace(Pisz)) return;
            Items.Add(Pisz);
            Pisz = string.Empty;
        }
    }
}
