using Lista.mvvm;

namespace Lista
{
    public partial class MainPage : ContentPage
    {
        //tutaj poprostu łaczymy pliki by główny plik mógł z tego korzystać
        public MainPage(CheckListViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            //gdzei tu używamy BindingContext czyli bedzie to główny plik który sprrawzaa czy w innym pliku zaszły zmiany 
        }


    }

}
