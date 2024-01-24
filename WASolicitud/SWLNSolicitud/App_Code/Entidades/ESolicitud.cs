using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de Solicitud
/// </summary>
[DataContract]
public class ESolicitud
{
    [DataMember]
    public string Solicitud_ID { get; set; }

    [DataMember]
    public DateTime FechaSolicitud { get; set; }

    [DataMember]
    public string TipoSolicitud { get; set; }

    [DataMember]
    public string Estado { get; set; }

    [DataMember]
    public string ID_Usuario { get; set; }
    public ESolicitud()
    {
        Solicitud_ID = string.Empty;
        FechaSolicitud = DateTime.Now;
        TipoSolicitud = string.Empty;
        Estado = string.Empty;
    }
}