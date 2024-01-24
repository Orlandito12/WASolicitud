using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de EUsuario
/// </summary>
/// 
[DataContract]
public class EUsuario
{
    [DataMember]
    public string Usuario_ID { get; set; }

    [DataMember]
    public string Nombre { get; set; }

    [DataMember]
    public string Apellido { get; set; }

    [DataMember]
    public string N_Identificación_Matricula { get; set; }

    [DataMember]
    public string Rol { get; set; }

    [DataMember]
    public string Telefono { get; set; }

    [DataMember]
    public string CorreoElectronico { get; set; }
    public EUsuario()
    {
        Usuario_ID = string.Empty;
        Nombre = string.Empty;
        Apellido = string.Empty;
        N_Identificación_Matricula = string.Empty;
        Rol = string.Empty;
        Telefono = string.Empty;
        CorreoElectronico = string.Empty;
    }
}