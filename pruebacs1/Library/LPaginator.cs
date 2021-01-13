using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebacs1.Library
{
    public class LPaginator <T>
    {
        private int Pag_count = 8;
        private int Pag_nav_links = 3;
        private int Pag_actual = 1;
        private string Pag_nav_Preview = "&laquo; Preview";
        private string Pag_nav_Next = "Next &raquo;";
        private string Pag_Firtspage = "&laquo; FirtsPage";
        private string Pag_Lastpage = "LastPage &raquo;";
        private string Pag_navigation = null;

        public object[] Paginator( List<T> table, int pagina, int pag_regis,
            string area, string controller, string action,string host)
        {
            Pag_actual = pagina == 0 ? 1 : pagina;
            Pag_count = pag_regis > 0 ? pag_regis : Pag_count;
            int Pag_totalCount = table.Count;
            double valor1 = Math.Ceiling((double)Pag_totalCount / (double)Pag_count);
            int Pag_total = Convert.ToInt16(Math.Ceiling(valor1));
            if (Pag_actual != 1)
            {
                int Pag_url = 1;
                Pag_navigation += "<a class='btn btn-default' href='" + host + "/" + controller + "/" 
                    + action + "?id" + Pag_url + "&registers" + Pag_count + "&area='" + area + "'>" + Pag_Firtspage + "</a>";
                Pag_url = -1;
                Pag_navigation += "<a class='btn btn-default' href='" + host + "/" + controller + "/"
                    + action + "?id" + Pag_url + "&registers" + Pag_count + "&area='" + area + "'>" + Pag_Lastpage + "</a>";
            }
            double valor2 = (Pag_nav_links / 2);
            int Pag_nav_interval = Convert.ToInt16(Math.Round(valor2));
            int Pag_nav_initial = Pag_actual - Pag_nav_interval;
            int Pag_nav_finalize = Pag_actual + Pag_nav_interval;
            if (Pag_nav_initial < 1)
            {
                Pag_nav_finalize -= (Pag_nav_initial - 1);
                Pag_nav_initial = 1;
            }
            if(Pag_nav_finalize > Pag_total)
            {
                Pag_nav_initial -= (Pag_nav_finalize - Pag_total);
                Pag_nav_finalize = Pag_total;
                if (Pag_nav_initial < 1)
                {
                    Pag_nav_initial = 1;
                }
            }
            for (var pags_i = Pag_nav_initial; pags_i <= Pag_nav_finalize; pags_i++)
            {
                if(pags_i == Pag_actual)
                {
                    Pag_navigation += "<span class='btn btn-default' disabled='disabled' >" + pags_i + "</span>";
                }
                else
                {
                    Pag_navigation += "<a class='btn btn-default' href='" + host + "/" + controller + "/"
                   + action + "?id" + pags_i + "&registers" + Pag_count + "&area='" + area + "'>" + pags_i + "</a>";
                }
                if (Pag_actual < Pag_total)
                {
                    int Pag_url = Pag_actual + 1;
                    Pag_navigation += "<a class='btn btn-default' href='" + host + "/" + controller + "/"
                        + action + "?id" + Pag_url + "&registers" + Pag_count + "&area='" + area + "'>" + Pag_nav_Next + "</a>";
                    Pag_url = Pag_total ;
                    Pag_navigation += "<a class='btn btn-default' href='" + host + "/" + controller + "/"
                        + action + "?id" + Pag_url + "&registers" + Pag_count + "&area='" + area + "'>" + Pag_Lastpage + "</a>";
                    Pag_url = Pag_actual - 1;
                    Pag_navigation += "<a class='btn btn-default' href='" + host + "/" + controller + "/"
                        + action + "?id" + Pag_url + "&registers" + Pag_count + "&area='" + area + "'>" + Pag_nav_Preview + "</a>";
                }
            }
            
            int pag_nav_inital = (Pag_actual - 1) * Pag_count;
            var query = table.Skip(pag_nav_inital).Take(Pag_count).ToList();
            string pag_info = "from <b>" + Pag_actual + "</b> to <b>" + Pag_total + "</b> of <b>" 
                + pag_regis + "</b>  <b>" + Pag_count + "</b>";
            object[] data = { pag_info, Pag_navigation, query };
                return data;
        }

       
    }
}
