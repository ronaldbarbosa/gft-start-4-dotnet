using System;
using System.Collections.Generic;
using app_series.DIO.Series.Interfaces;

namespace app_series.DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public List<Serie> Lista()
        {
            return listaSerie;
        }
        public Serie RetornaPorID (int id)
        {
            return listaSerie[id];
        }
        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }
        public int ProximoID()
        {
            return listaSerie.Count;
        }
    }
}