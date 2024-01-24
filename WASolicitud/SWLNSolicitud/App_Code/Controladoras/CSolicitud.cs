using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CSolicitud
/// </summary>
public class CSolicitud
{
    public CSolicitud()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    
    public List<ESolicitud> Obtener_ESolicitud()
    {
        List<ESolicitud> lstESolicitud = new List<ESolicitud>();
       // lstEBBeca = asNetSolicitud.Obtener_Solicitud();
        foreach (ESolicitud eBBeca in lstESolicitud)
        {
            if (eBBeca.Estado == "pendiente")
            {
                ESolicitud eSolicitud = new ESolicitud();
                
                lstESolicitud.Add(eSolicitud);
            }
        }
        return lstESolicitud;

    }
    public bool AgregarSolicitud(ESolicitud eSolicitud)
    {
        string NombreMetodo = "AgregarSolicitud";
        try
        {
            eSolicitud.Estado = "Pendiente";
            eSolicitud.TipoSolicitud = "firma Digital";
            eSolicitud.FechaSolicitud = DateTime.Now;
            //asNetBec.Adicionar_BRequisito(eSolicitud);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

}