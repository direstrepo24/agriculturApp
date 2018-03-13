using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Notificaciones")]
  public class Notificacione
  {
    public string EstadoNotif
    {
      get;
      set;
    }
    public DateTime Fecha
    {
      get;
      set;
    }
    [Key]
    public Int64 Id
    {
      get;
      set;
    }
    public string Mensaje
    {
      get;
      set;
    }
    public Int64? TypeNotificationId1
    {
      get;
      set;
    }

    [ForeignKey("TypeNotificationId1")]
    public TypeNotification TypeNotification { get; set; }
  }
}
