using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Entity;
using System.Collections.ObjectModel;


namespace Vista.ViewModel
{

   public class ListaViewModel : ViewModelBase
    {
        public ObservableCollection<Categoria> Categorias { get; set; }

        public ICommand NuevoCommand { get; set; }
        public ICommand ConsultaCommand { get; set; }

        public void ListaCategoriaViewModel()
        {
            Categorias = new Model.CategoriaModel().Categorias;

            NuevoCommand = new RelayCommand<Window>(
                param => Abrir()
                );

            ConsultaCommand = new RelayCommand<object>(

                o => { Categorias = (new Model.CategoriaModel()).Categorias; }
                );
            void Abrir() {


                ManCategoria window = new ManCategoria();

                window.ShowDialog();
                

            }
         
        }
        
        

    }
}
