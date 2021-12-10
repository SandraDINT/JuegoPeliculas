using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class PeliculaMVVM : ObservableObject
{
    
    private ListaPeliculasService servicioPeliculas;
    private AzureService azureService;

    public PeliculaMVVM()
    {
        servicioPeliculas = new ListaPeliculasService();
        _listaPeliculas = servicioPeliculas.GetPeliculas();
        PeliculaActual = _listaPeliculas.FirstOrDefault();
        ContadorPeliculaActual = 1;
        TotalPeliculas = _listaPeliculas.Count;
    }

    private ObservableCollection<Pelicula> _listaPeliculas;
    public ObservableCollection<Pelicula> Peliculas {
        get { return _listaPeliculas; }
        set { SetProperty(ref _listaPeliculas, value); } 
    }

    private Pelicula _peliculaActual;
    public Pelicula PeliculaActual
    {
        get { return _peliculaActual; }
        set
        {
            SetProperty(ref _peliculaActual, value);
        }
    }

    private int _contadorPeliculaActual;
    public int ContadorPeliculaActual
    {
        get { return _contadorPeliculaActual; }
        set { SetProperty(ref _contadorPeliculaActual, value); }
    }

    private int _totalPeliculas;
    public int TotalPeliculas
    {
        get { return _totalPeliculas; }
        set { SetProperty(ref _totalPeliculas, value); }
    }

    public void Avanzar()
    {
        if (ContadorPeliculaActual < TotalPeliculas)
        {
            ContadorPeliculaActual++;
            PeliculaActual = _listaPeliculas[ContadorPeliculaActual - 1];
        }

    }
    public void Retroceder()
    {
        if (ContadorPeliculaActual > 1)
        {
            ContadorPeliculaActual--;
            PeliculaActual = _listaPeliculas[ContadorPeliculaActual - 1];
        }
    }
}

